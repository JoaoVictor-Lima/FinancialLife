using FinancialLifeInfrastructureData.Configuration;
using FinancialLifeInfrastructureData.Context;
using FinancialLifeInfrastructureData.DbServices.Interface;
using FinancialLifeInfrastructureData.Utils.Enum;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Logging;
using System.ComponentModel;
using System.Text;

namespace FinancialLifeInfrastructureData.DbServices
{
    public class MigrationEnums : IMigrationEnums
    {
        private readonly FinancialLifeDbContext _context;
        private readonly ILogger<MigrationEnums> _logger;

        private EnumMapConfig EnumMapConfig { get; set; }

        public MigrationEnums(FinancialLifeDbContext context, ILogger<MigrationEnums> logger)
        {
            _context = context;
            _logger = logger;
            EnumMapConfig = new EnumMapConfig();
        }


        public Task MigrateEnums()
        {
            _logger.LogInformation("Starting enum migration...");

            var (newEnums, enumsToUpdate) = GetEnumsToMigration();

            if (newEnums.Count() > 0)
                MigrateNewEnums(newEnums);

            if (enumsToUpdate.Count > 0)
                UpdateEnumsDataBase(enumsToUpdate);

            AddConstraints();

            _logger.LogInformation("Enum migration completed.");
            return Task.CompletedTask;
        }

        private void AddConstraints()
        {
            var model = _context.Model;

            foreach (var relationship in EnumMapConfig.EnumsRelationshipRegister)
            {
                foreach (var entityType in relationship.EntityTypes)
                {
                    var entityTypeName = model.FindEntityType(entityType)?.GetTableName();
                    var enumTableName = GetTableName(relationship.EnumRegistration);
                    var foreignKeyPropertyName = GetForeignKeyPropertyName(model.FindEntityType(entityType), relationship.EnumRegistration.Enum);

                    if (entityTypeName != null && enumTableName != null)
                    {
                        var constraintName = $"FK_{entityTypeName}_{enumTableName}";

                        if (!ConstraintExists(entityTypeName, constraintName))
                        {
                            var command = $@"
                                    ALTER TABLE {entityTypeName}
                                    ADD CONSTRAINT {constraintName}
                                    FOREIGN KEY ({foreignKeyPropertyName}) REFERENCES {enumTableName}(Id);
                                 ";

                            _context.Database.ExecuteSqlRaw(command);

                            Console.WriteLine($"Constraint added: {constraintName}");
                        }
                    }
                }
            }
        }

        private bool ConstraintExists(string tableName, string constraintName)
        {
            var checkCommand = $@"
                SELECT COUNT(*)
                FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS
                WHERE CONSTRAINT_TYPE = 'FOREIGN KEY'
                    AND TABLE_NAME = '{tableName}'
                    AND CONSTRAINT_NAME = '{constraintName}';
            ";

            var exists = _context.Database.GetDbConnection().CreateCommand();
            exists.CommandText = checkCommand;

            if (exists.Connection.State != System.Data.ConnectionState.Open)
            {
                exists.Connection.Open();
            }

            var result = (int)exists.ExecuteScalar();
            return result > 0;
        }

        private string GetForeignKeyPropertyName(IEntityType entityType, Type enumType)
        {
            var property = entityType.GetProperties()
                .FirstOrDefault(p => p.ClrType == enumType);

            if (property == null)
            {
                return "";
            }

            return property.GetColumnName(StoreObjectIdentifier.Table(entityType.GetTableName(), null));
        }

        private (List<EnumRegistration> newEnums, List<EnumRegistration> newnums) GetEnumsToMigration()
        {
            var newEnums = new List<EnumRegistration>();
            var enumsToUpdate = new List<EnumRegistration>();
            var existingTable = GetExistingTables();

            EnumMapConfig.EnumsRegistration.ForEach(x =>
            {
                if (!existingTable.Contains(GetTableName(x)))
                {
                    newEnums.Add(x);
                }
                else
                {
                    if (IsEnumToUpdate(x))
                        enumsToUpdate.Add(x);
                }
            });


            return (newEnums, enumsToUpdate);
        }

        private bool IsEnumToUpdate(EnumRegistration enumRegister)
        {

            var enumValues = Enum.GetValues(enumRegister.Enum)
                      .Cast<Enum>()
                      .Select(e => new { Id = Convert.ToInt32(e), Description = GetEnumDescription(e) })
                      .ToList();

            var enumDbValues = GetEnumDb(GetTableName(enumRegister)).ToList();

            if (enumValues.Count != enumDbValues.Count)
                return true;

            foreach (var enumValue in enumValues)
            {
                if (!enumDbValues.Any(dbValue => dbValue.Id == enumValue.Id && dbValue.Description == enumValue.Description))
                {
                    return true;
                }
            }

            return false;
        }

        public void UpdateEnumsDataBase(List<EnumRegistration> enumsRegister)
        {
            foreach (var enumRegister in enumsRegister)
            {
                List<EnumDbValueClass> enumValues = Enum.GetValues(enumRegister.Enum).Cast<Enum>().Select(e => new EnumDbValueClass(
                        id: Convert.ToInt32(e),
                        description: GetEnumDescription(e)
                    )).ToList();

                var enumDbValues = GetEnumDb(GetTableName(enumRegister)).ToList();


                List<EnumDbValueClass> enumsValuesToAdd = new List<EnumDbValueClass>();
                List<EnumDbValueClass> enumsValuesToDelete = new List<EnumDbValueClass>();
                List<EnumDbValueClass> enumsValuesToUpdate = new List<EnumDbValueClass>();

                foreach (var enumValue in enumValues)
                {
                    var dbValue = enumDbValues.FirstOrDefault(db => db.Id == enumValue.Id);

                    if (dbValue == null)
                        enumsValuesToAdd.Add(enumValue);

                    else if (dbValue.Description != enumValue.Description)
                        enumsValuesToUpdate.Add(new EnumDbValueClass(enumValue.Id, enumValue.Description));
                }

                foreach (var enumDbValue in enumDbValues)
                {
                    if (!enumValues.Any(enumValue => enumValue.Id == enumDbValue.Id))
                    {
                        enumsValuesToDelete.Add(enumDbValue);
                    }
                }

                if (enumsValuesToAdd.Count() > 0) InsertEnumValues(GetTableName(enumRegister), enumsValuesToAdd);
                if (enumsValuesToDelete.Count() > 0) DeleteEnumValues(GetTableName(enumRegister), enumsValuesToDelete);
                if (enumsValuesToUpdate.Count() > 0) UpdateEnumValues(GetTableName(enumRegister), enumsValuesToUpdate);
            }
        }

        public void MigrateNewEnums(List<EnumRegistration> newEnums)
        {
            newEnums.ForEach(enumRegister =>
            {
                if (!enumRegister.Enum.IsEnum)
                    throw new ArgumentException($"{enumRegister.Enum.Name} is not enum.");

                var tableName = GetTableName(enumRegister);
                List<EnumDbValueClass> enumValues = Enum.GetValues(enumRegister.Enum).Cast<Enum>().Select(e => new EnumDbValueClass(
                        id: Convert.ToInt32(e),
                        description: GetEnumDescription(e)
                    )).ToList();


                CreateEnumTable(tableName);
                InsertEnumValues(tableName, enumValues);
            });
        }

        private void CreateEnumTable(string tableName)
        {
            _context.Database.ExecuteSqlRaw($@"
                CREATE TABLE {tableName} (
                    Id INT PRIMARY KEY IDENTITY,
                    Description VARCHAR(500) NULL
                );
            ");
        }

        private void InsertEnumValues(string tableName, List<EnumDbValueClass> enumValues)
        {
            StringBuilder insert = new StringBuilder();

            insert.Append($@"SET IDENTITY_INSERT {tableName} ON
                             INSERT INTO {tableName} (Id, Description)
                             VALUES");


            bool first = true;
            Console.WriteLine(enumValues.Count());
            foreach (var value in enumValues)
            {

                if (!first)
                    insert.Append(",");

                insert.AppendLine($"({value.Id}, '{value.Description}')");

                first = false;
            }
            insert.Append($"SET IDENTITY_INSERT {tableName} OFF;");
            _context.Database.ExecuteSqlRaw(insert.ToString());
        }

        private void UpdateEnumValues(string tableName, List<EnumDbValueClass> enumsToUpdate)
        {
            StringBuilder update = new StringBuilder();

            foreach (var enumValue in enumsToUpdate)
            {
                update.Append($@"
                    UPDATE {tableName}
                    SET Description = '{enumValue.Description}'
                    WHERE Id = {enumValue.Id};
                ");
            }
            _context.Database.ExecuteSqlRaw(update.ToString());
        }

        private void DeleteEnumValues(string tableName, List<EnumDbValueClass> enumsToDelete)
        {
            StringBuilder delete = new StringBuilder();

            var idsToDelete = string.Join(",", enumsToDelete.Select(x => x.Id));

            delete.Append($@"DELETE FROM {tableName}
                  WHERE Id IN ({idsToDelete})");

            _context.Database.ExecuteSqlRaw(delete.ToString());
        }

        private static string GetEnumDescription(Enum enumValue)
        {
            var fieldInfo = enumValue.GetType().GetField(enumValue.ToString());
            var descriptionAttribute = (DescriptionAttribute)fieldInfo
                .GetCustomAttributes(typeof(DescriptionAttribute), false)
                .FirstOrDefault();

            return descriptionAttribute != null ? descriptionAttribute.Description : string.Empty;
        }

        private string RemoveEnumSuffix(string enumName)
        {
            const string enumSuffix = "Enum";

            if (enumName.EndsWith(enumSuffix))
            {
                return enumName.Substring(0, enumName.Length - enumSuffix.Length);
            }

            return enumName;
        }

        private string GetTableName(EnumRegistration enumRegister)
        {
            return enumRegister.TableName ?? RemoveEnumSuffix(enumRegister.Enum.Name);
        }


        private List<string> GetExistingTables()
        {
            var tables = new List<string>();

            var connection = _context.Database.GetDbConnection();

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            var commandText = "SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";
            using (var command = new SqlCommand(commandText, (SqlConnection)connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    tables.Add(reader.GetString(0));
                }
            }


            return tables;
        }

        private List<EnumDbValueClass> GetEnumDb(string tableName)
        {
            var tables = new List<EnumDbValueClass>();

            var connection = _context.Database.GetDbConnection();

            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }

            var commandText = $"SELECT Id, Description FROM {tableName}";
            using (var command = new SqlCommand(commandText, (SqlConnection)connection))
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    tables.Add(new EnumDbValueClass
                    {
                        Id = reader.GetInt32(reader.GetOrdinal("Id")),
                        Description = reader.GetString(reader.GetOrdinal("Description")),
                    });
                }
            }


            return tables;
        }
    }
}

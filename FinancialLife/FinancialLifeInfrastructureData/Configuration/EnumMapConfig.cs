using ContractEntity.Enums.Core.People.NatualPerson;
using ContractEntity.Enums.Core.Utils;
using FinancialLifeDomain.Entities.Core.People;

namespace FinancialLifeInfrastructureData.Configuration
{
    public class EnumMapConfig
    {
        public List<EnumRegistration> EnumsRegistration { get; private set; } = new List<EnumRegistration>();
        public List<EnumRelationshipRegister> EnumsRelationshipRegister { get; private set; } = new List<EnumRelationshipRegister>();


        public EnumMapConfig()
        {
            #region Register Enums

            AddEnumRegister(typeof(PersonGenderEnum));
            AddEnumRegister(typeof(MonthEnum));


            #endregion

            #region Register Relationship

            AddEnumRelationship(typeof(PersonGenderEnum), typeof(NaturalPerson));

            #endregion
        }


        public void AddEnumRelationship(Type enumType, params Type[] entityTypes)
        {
            if (!enumType.IsEnum)
            {
                throw new ArgumentException($"{enumType.Name} não é um enum.", nameof(enumType));
            }

            var enumRegisterType = EnumsRegistration.Where(x => x.Enum == enumType).FirstOrDefault();

            EnumsRelationshipRegister.Add(new EnumRelationshipRegister(enumRegisterType, entityTypes));
        }
        public void AddEnumRegister(Type enumType) 
        {
            EnumsRegistration.Add(new EnumRegistration(enumType));
        }
    }

    public class EnumRegistration
    {
        public Type Enum { get; set; }
        public string TableName { get; set; }

        public EnumRegistration(Type enumType)
        {
            Enum = enumType;
        }
        public EnumRegistration(Type enumType, string tableName)
        {
            Enum = enumType;
            TableName = tableName;
        }
    }

    public class EnumRelationshipRegister
    {
        public EnumRegistration EnumRegistration{ get; set; }
        public List<Type> EntityTypes { get; set; }

        public EnumRelationshipRegister(EnumRegistration enumRegistration, params Type[] entityTypes)
        {
            EnumRegistration = enumRegistration;
            EntityTypes = new List<Type>(entityTypes);
        }
    }

}

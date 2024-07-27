using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinancialLifeInfrastructureData.Migrations
{
    /// <inheritdoc />
    public partial class RemigrationWithEnumMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmailLogin = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    Password = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    IdNaturalPerson = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "State",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    StateAbbreviation = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false),
                    IdCountry = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_State", x => x.Id);
                    table.ForeignKey(
                        name: "FK_State_Country_IdCountry",
                        column: x => x.IdCountry,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EmailPerson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    IdPerson = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailPerson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EmailPerson_Person_IdPerson",
                        column: x => x.IdPerson,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LegalEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LegalEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LegalEntity_Person_Id",
                        column: x => x.Id,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NaturalPerson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false),
                    DocumentNumber = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false),
                    IdPersonGender = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NaturalPerson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NaturalPerson_Person_Id",
                        column: x => x.Id,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PhonePerson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaCode = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false),
                    Number = table.Column<string>(type: "varchar(9)", maxLength: 9, nullable: false),
                    IdPerson = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhonePerson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhonePerson_Person_IdPerson",
                        column: x => x.IdPerson,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    IdState = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_State_IdState",
                        column: x => x.IdState,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PersonAddress",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Number = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    AddressComplement = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    District = table.Column<string>(type: "varchar(300)", maxLength: 300, nullable: false),
                    IdCity = table.Column<int>(type: "int", nullable: false),
                    IdState = table.Column<int>(type: "int", nullable: false),
                    IdCountry = table.Column<int>(type: "int", nullable: false),
                    IdPerson = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonAddress", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonAddress_City_IdCity",
                        column: x => x.IdCity,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonAddress_Country_IdCountry",
                        column: x => x.IdCountry,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonAddress_Person_IdPerson",
                        column: x => x.IdPerson,
                        principalTable: "Person",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PersonAddress_State_IdState",
                        column: x => x.IdState,
                        principalTable: "State",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_City_IdState",
                table: "City",
                column: "IdState");

            migrationBuilder.CreateIndex(
                name: "IX_EmailPerson_IdPerson",
                table: "EmailPerson",
                column: "IdPerson");

            migrationBuilder.CreateIndex(
                name: "IX_PersonAddress_IdCity",
                table: "PersonAddress",
                column: "IdCity");

            migrationBuilder.CreateIndex(
                name: "IX_PersonAddress_IdCountry",
                table: "PersonAddress",
                column: "IdCountry");

            migrationBuilder.CreateIndex(
                name: "IX_PersonAddress_IdPerson",
                table: "PersonAddress",
                column: "IdPerson");

            migrationBuilder.CreateIndex(
                name: "IX_PersonAddress_IdState",
                table: "PersonAddress",
                column: "IdState");

            migrationBuilder.CreateIndex(
                name: "IX_PhonePerson_IdPerson",
                table: "PhonePerson",
                column: "IdPerson");

            migrationBuilder.CreateIndex(
                name: "IX_State_IdCountry",
                table: "State",
                column: "IdCountry");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmailPerson");

            migrationBuilder.DropTable(
                name: "LegalEntity");

            migrationBuilder.DropTable(
                name: "NaturalPerson");

            migrationBuilder.DropTable(
                name: "PersonAddress");

            migrationBuilder.DropTable(
                name: "PhonePerson");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "City");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.DropTable(
                name: "State");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}

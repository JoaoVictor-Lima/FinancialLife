using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FinancialLifeInfrastructureData.Migrations
{
    /// <inheritdoc />
    public partial class CorrectionsInDbBecouseGeneroPessoa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PessoaFisica_GeneroPessoa_IdGeneroPessoa",
                table: "PessoaFisica");

            migrationBuilder.DropTable(
                name: "GeneroPessoa");

            migrationBuilder.DropIndex(
                name: "IX_PessoaFisica_IdGeneroPessoa",
                table: "PessoaFisica");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GeneroPessoa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GeneroPessoa", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PessoaFisica_IdGeneroPessoa",
                table: "PessoaFisica",
                column: "IdGeneroPessoa",
                unique: true,
                filter: "[IdGeneroPessoa] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_PessoaFisica_GeneroPessoa_IdGeneroPessoa",
                table: "PessoaFisica",
                column: "IdGeneroPessoa",
                principalTable: "GeneroPessoa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

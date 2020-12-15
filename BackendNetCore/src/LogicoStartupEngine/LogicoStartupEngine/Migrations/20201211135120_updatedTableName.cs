using Microsoft.EntityFrameworkCore.Migrations;

namespace LogicoStartupEngine.Migrations
{
    public partial class updatedTableName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LogistticCompanies",
                table: "LogistticCompanies");

            migrationBuilder.RenameTable(
                name: "LogistticCompanies",
                newName: "LogisticCompanies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LogisticCompanies",
                table: "LogisticCompanies",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_LogisticCompanies",
                table: "LogisticCompanies");

            migrationBuilder.RenameTable(
                name: "LogisticCompanies",
                newName: "LogistticCompanies");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LogistticCompanies",
                table: "LogistticCompanies",
                column: "Id");
        }
    }
}

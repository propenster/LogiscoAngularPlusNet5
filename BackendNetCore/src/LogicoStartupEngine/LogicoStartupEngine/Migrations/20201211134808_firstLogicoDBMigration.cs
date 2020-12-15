using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LogicoStartupEngine.Migrations
{
    public partial class firstLogicoDBMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LogistticCompanies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(type: "varchar(50)", nullable: false),
                    CompanyEmail = table.Column<string>(type: "varchar(32)", nullable: false),
                    CompanyPhoneNumber = table.Column<string>(type: "varchar(13)", nullable: false),
                    CompanyAddress = table.Column<string>(type: "varchar(150)", nullable: false),
                    CompanyLocation = table.Column<string>(type: "varchar(50)", nullable: false),
                    CompanyDescription = table.Column<string>(type: "varchar(max)", nullable: false),
                    CompanyRegistrationNumber = table.Column<string>(type: "varchar(10)", nullable: false),
                    CompanyTaxRegistrationNumber = table.Column<string>(type: "varchar(15)", nullable: false),
                    CompanyReferencePhoneNumber = table.Column<string>(type: "varchar(13)", nullable: false),
                    CompanyReferenceEmail = table.Column<string>(type: "varchar(32)", nullable: false),
                    CompanyWebsiteURL = table.Column<string>(type: "varchar(2048)", nullable: false),
                    CompanyImageURL = table.Column<string>(type: "varchar(2048)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LogistticCompanies", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LogistticCompanies");
        }
    }
}

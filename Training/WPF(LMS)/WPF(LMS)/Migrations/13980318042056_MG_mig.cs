using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WPF_LMS_.Migrations
{
    public partial class MG_mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mg_InfM",
                columns: table => new
                {
                    Mg_ModelsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    BirthDate = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    MeliCode = table.Column<int>(nullable: false),
                    OrgCode = table.Column<int>(nullable: false),
                    Phone = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mg_InfM", x => x.Mg_ModelsId);
                });

            migrationBuilder.CreateTable(
                name: "St_InfM",
                columns: table => new
                {
                    St_ModelsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UniCode = table.Column<int>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    Birthdate = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    MeliCode = table.Column<int>(nullable: false),
                    Phone = table.Column<int>(nullable: false),
                    UniLog = table.Column<int>(nullable: false),
                    Vahedha = table.Column<int>(nullable: false),
                    Major = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_St_InfM", x => x.St_ModelsId);
                });

            migrationBuilder.CreateTable(
                name: "Tch_InfM",
                columns: table => new
                {
                    Tch_ModelsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    BirthDate = table.Column<int>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    MeliCode = table.Column<int>(nullable: false),
                    OrgCode = table.Column<int>(nullable: false),
                    Phone = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tch_InfM", x => x.Tch_ModelsId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mg_InfM");

            migrationBuilder.DropTable(
                name: "St_InfM");

            migrationBuilder.DropTable(
                name: "Tch_InfM");
        }
    }
}

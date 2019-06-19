using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WPF_LMS_.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Marks",
                columns: table => new
                {
                    AllMarksId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Major = table.Column<string>(nullable: true),
                    Riazi1 = table.Column<int>(nullable: false),
                    Moadelat = table.Column<int>(nullable: false),
                    Adabiat = table.Column<int>(nullable: false),
                    Andishe = table.Column<int>(nullable: false),
                    St_ModelsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marks", x => x.AllMarksId);
                    table.ForeignKey(
                        name: "FK_Marks_St_InfM_St_ModelsId",
                        column: x => x.St_ModelsId,
                        principalTable: "St_InfM",
                        principalColumn: "St_ModelsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Marks_St_ModelsId",
                table: "Marks",
                column: "St_ModelsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Marks");
        }
    }
}

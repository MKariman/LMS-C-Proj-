using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WPF_LMS_.Migrations
{
    public partial class n123 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Term2M",
                columns: table => new
                {
                    T2MarksId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BSignal = table.Column<int>(nullable: false),
                    BAnalyz = table.Column<int>(nullable: false),
                    CNetwork = table.Column<int>(nullable: false),
                    CAp = table.Column<int>(nullable: false),
                    Ozamin = table.Column<int>(nullable: false),
                    OLarze = table.Column<int>(nullable: false),
                    MJamedat = table.Column<int>(nullable: false),
                    MHarekatshenasi = table.Column<int>(nullable: false),
                    ShEnergy = table.Column<int>(nullable: false),
                    ShKar = table.Column<int>(nullable: false),
                    MeDesign = table.Column<int>(nullable: false),
                    MeAuto = table.Column<int>(nullable: false),
                    St_ModelsId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Term2M", x => x.T2MarksId);
                    table.ForeignKey(
                        name: "FK_Term2M_St_InfM_St_ModelsId",
                        column: x => x.St_ModelsId,
                        principalTable: "St_InfM",
                        principalColumn: "St_ModelsId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Term2M_St_ModelsId",
                table: "Term2M",
                column: "St_ModelsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Term2M");
        }
    }
}

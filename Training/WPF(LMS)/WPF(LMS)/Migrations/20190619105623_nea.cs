using Microsoft.EntityFrameworkCore.Migrations;

namespace WPF_LMS_.Migrations
{
    public partial class nea : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Marks",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "BCmos",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BElectro",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BMadar",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BQodrat",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BVLSI",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BarqMId",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CDatabase",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CGosaste",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CInteligence",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CManteqi",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CProgramming",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CompMId",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MControl",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MFizik",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MMashin",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MSayalat",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MTermo",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MechMId",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MeDekor",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MeFazas",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MeNama",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MeNaqshe",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MeTarahi",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MemMId",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OBotons",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ODinamik",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OMasaleh",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ONaqshe",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OStatik",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "OmranMId",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SHGaz",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SHHararat",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SHJerm",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SHMavad",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SHSinema",
                table: "Marks",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ShimiMId",
                table: "Marks",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "BCmos",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "BElectro",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "BMadar",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "BQodrat",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "BVLSI",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "BarqMId",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "CDatabase",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "CGosaste",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "CInteligence",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "CManteqi",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "CProgramming",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "CompMId",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "MControl",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "MFizik",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "MMashin",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "MSayalat",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "MTermo",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "MechMId",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "MeDekor",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "MeFazas",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "MeNama",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "MeNaqshe",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "MeTarahi",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "MemMId",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "OBotons",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "ODinamik",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "OMasaleh",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "ONaqshe",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "OStatik",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "OmranMId",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "SHGaz",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "SHHararat",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "SHJerm",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "SHMavad",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "SHSinema",
                table: "Marks");

            migrationBuilder.DropColumn(
                name: "ShimiMId",
                table: "Marks");
        }
    }
}

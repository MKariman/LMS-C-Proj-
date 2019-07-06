using Microsoft.EntityFrameworkCore.Migrations;

namespace WPF_LMS_.Migrations
{
    public partial class Lol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Education",
                table: "Tch_InfM",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TeachingLesson",
                table: "Tch_InfM",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Riazi1",
                table: "Marks",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Moadelat",
                table: "Marks",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Andishe",
                table: "Marks",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "Adabiat",
                table: "Marks",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Education",
                table: "Tch_InfM");

            migrationBuilder.DropColumn(
                name: "TeachingLesson",
                table: "Tch_InfM");

            migrationBuilder.AlterColumn<int>(
                name: "Riazi1",
                table: "Marks",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Moadelat",
                table: "Marks",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Andishe",
                table: "Marks",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Adabiat",
                table: "Marks",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}

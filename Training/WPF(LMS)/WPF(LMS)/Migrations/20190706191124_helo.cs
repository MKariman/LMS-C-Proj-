using Microsoft.EntityFrameworkCore.Migrations;

namespace WPF_LMS_.Migrations
{
    public partial class helo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Education",
                table: "Mg_InfM",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Post",
                table: "Mg_InfM",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Education",
                table: "Mg_InfM");

            migrationBuilder.DropColumn(
                name: "Post",
                table: "Mg_InfM");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeesRazor.Migrations
{
    public partial class AddPostToEmplyeeDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Post",
                table: "Employees",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Post",
                table: "Employees");
        }
    }
}

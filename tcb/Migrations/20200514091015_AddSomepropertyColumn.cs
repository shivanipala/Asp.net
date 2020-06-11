using Microsoft.EntityFrameworkCore.Migrations;

namespace tcb.Migrations
{
    public partial class AddSomepropertyColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Someproperty",
                table: "Employees",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Someproperty",
                table: "Employees");
        }
    }
}

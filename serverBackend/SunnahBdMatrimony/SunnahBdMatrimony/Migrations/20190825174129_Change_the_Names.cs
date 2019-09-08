using Microsoft.EntityFrameworkCore.Migrations;

namespace SunnahBdMatrimony.Migrations
{
    public partial class Change_the_Names : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Values",
                newName: "Names");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Names",
                table: "Values",
                newName: "Name");
        }
    }
}

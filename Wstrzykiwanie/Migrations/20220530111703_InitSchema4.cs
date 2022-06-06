using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wstrzykiwanie.Migrations
{
    public partial class InitSchema4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Person",
                newName: "PersonID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PersonID",
                table: "Person",
                newName: "ID");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Wstrzykiwanie.Migrations
{
    public partial class InitSchema3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "Person",
                newName: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Person",
                newName: "PersonId");
        }
    }
}

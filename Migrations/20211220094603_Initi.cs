using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiEroski.Migrations
{
    public partial class Initi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketItem",
                table: "TicketItem");

            migrationBuilder.RenameTable(
                name: "TicketItem",
                newName: "TicketsItem");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketsItem",
                table: "TicketsItem",
                column: "Nombre");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_TicketsItem",
                table: "TicketsItem");

            migrationBuilder.RenameTable(
                name: "TicketsItem",
                newName: "TicketItem");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TicketItem",
                table: "TicketItem",
                column: "Nombre");
        }
    }
}

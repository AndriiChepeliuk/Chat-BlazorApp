using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chat_BlazorApp.Data.Migrations
{
    public partial class AddedColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublicName",
                table: "AspNetUsers",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "AspNetUsers",
                newName: "PublicName");
        }
    }
}

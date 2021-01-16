using Microsoft.EntityFrameworkCore.Migrations;

namespace WillBlazor.Server.Data.Migrations
{
    public partial class mig9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Pictures",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhotoCredit",
                table: "Pictures",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Pictures");

            migrationBuilder.DropColumn(
                name: "PhotoCredit",
                table: "Pictures");
        }
    }
}

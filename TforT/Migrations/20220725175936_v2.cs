using Microsoft.EntityFrameworkCore.Migrations;

namespace TforT.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MobileId",
                table: "users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MobileId",
                table: "users",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}

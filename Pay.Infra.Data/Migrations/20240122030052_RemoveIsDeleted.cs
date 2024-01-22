using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pay.Infra.Data.Migrations
{
    public partial class RemoveIsDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Bank");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Bank",
                type: "boolean",
                nullable: false,
                defaultValue: false);
        }
    }
}

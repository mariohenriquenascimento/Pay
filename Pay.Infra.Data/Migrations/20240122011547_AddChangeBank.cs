using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pay.Infra.Data.Migrations
{
    public partial class AddChangeBank : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentSlip_bank_BankId",
                table: "PaymentSlip");

            migrationBuilder.DropPrimaryKey(
                name: "PK_bank",
                table: "bank");

            migrationBuilder.RenameTable(
                name: "bank",
                newName: "Bank");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Bank",
                table: "Bank",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentSlip_Bank_BankId",
                table: "PaymentSlip",
                column: "BankId",
                principalTable: "Bank",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentSlip_Bank_BankId",
                table: "PaymentSlip");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Bank",
                table: "Bank");

            migrationBuilder.RenameTable(
                name: "Bank",
                newName: "bank");

            migrationBuilder.AddPrimaryKey(
                name: "PK_bank",
                table: "bank",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentSlip_bank_BankId",
                table: "PaymentSlip",
                column: "BankId",
                principalTable: "bank",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

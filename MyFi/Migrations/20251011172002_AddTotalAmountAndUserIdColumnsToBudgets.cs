using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyFi.Migrations
{
    /// <inheritdoc />
    public partial class AddTotalAmountAndUserIdColumnsToBudgets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Frequency",
                table: "Expenses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalAmount",
                table: "Budgets",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Budgets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Frequency",
                table: "Expenses");

            migrationBuilder.DropColumn(
                name: "TotalAmount",
                table: "Budgets");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Budgets");
        }
    }
}

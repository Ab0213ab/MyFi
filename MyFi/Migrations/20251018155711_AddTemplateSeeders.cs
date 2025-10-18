using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MyFi.Migrations
{
    /// <inheritdoc />
    public partial class AddTemplateSeeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BudgetTemplates",
                columns: new[] { "Id", "Category", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "General", "A balanced starter budget covering everyday expenses.", "Essential Living" },
                    { 2, "Student", "A lean, student-friendly budget for managing limited income.", "College Student" },
                    { 3, "Debt Management", "A focused budget to aggressively reduce debt while maintaining essential living costs.", "High Debt Paydown" },
                    { 4, "Balanced", "A simple, balanced budget based on the classic 50% needs, 30% wants, 20% savings model.", "50/30/20 Rule" }
                });

            migrationBuilder.InsertData(
                table: "CategoryTemplates",
                columns: new[] { "Id", "BudgetTemplateId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Mortgage or rent and home-related bills.", "Housing" },
                    { 2, 1, "Electricity, water, internet, phone, etc.", "Utilities" },
                    { 3, 1, "Vehicle costs, gas, insurance, and maintenance.", "Transportation" },
                    { 4, 1, "Groceries and dining out.", "Food" },
                    { 5, 1, "Debt payments, savings, or investments.", "Savings & Debt" },
                    { 6, 2, "Dorm or apartment rent.", "Housing" },
                    { 7, 2, "Meal plan or groceries.", "Food" },
                    { 8, 2, "Tuition, books, and course materials.", "Education" },
                    { 9, 2, "Bus pass, car, or ride-sharing costs.", "Transportation" },
                    { 10, 2, "Entertainment, hobbies, or outings.", "Leisure" },
                    { 11, 3, "Essential housing expenses.", "Housing" },
                    { 12, 3, "Essential commuting or vehicle costs.", "Transportation" },
                    { 13, 3, "Groceries only; minimal dining out.", "Food" },
                    { 14, 3, "Debt payoff and emergency reserves.", "Debt & Savings" },
                    { 15, 3, "Basic personal and household needs.", "Miscellaneous" },
                    { 16, 4, "Essential bills, housing, and groceries.", "Needs" },
                    { 17, 4, "Non-essential but enjoyable spending.", "Wants" },
                    { 18, 4, "Savings, debt payments, and investments.", "Savings & Debt" }
                });

            migrationBuilder.InsertData(
                table: "ExpenseTemplates",
                columns: new[] { "Id", "BudgetTemplateId", "CategoryTemplateId", "Description", "Frequency", "Name", "PercentageOfTotal" },
                values: new object[,]
                {
                    { 1, 1, 1, "Monthly rent or mortgage payment.", 3, "Rent or Mortgage", 0.30m },
                    { 2, 1, 2, "Electricity, water, and internet bills.", 3, "Utilities", 0.10m },
                    { 3, 1, 3, "Fuel, maintenance, and insurance.", 3, "Transportation", 0.15m },
                    { 4, 1, 4, "Weekly grocery shopping.", 1, "Groceries", 0.15m },
                    { 5, 1, 4, "Restaurants or takeout.", 1, "Dining Out", 0.05m },
                    { 6, 1, 5, "Credit card or loan payments.", 3, "Debt Payments", 0.15m },
                    { 7, 1, 5, "Set aside funds for emergencies.", 3, "Emergency Savings", 0.10m },
                    { 8, 2, 6, "Dorm or apartment rent.", 3, "Rent", 0.35m },
                    { 9, 2, 7, "Food, snacks, or shared groceries.", 1, "Groceries", 0.20m },
                    { 10, 2, 8, "Tuition, textbooks, and class materials.", 5, "Tuition & Fees", 0.25m },
                    { 11, 2, 9, "Bus, fuel, or ride-share expenses.", 3, "Transportation", 0.10m },
                    { 12, 2, 10, "Movies, events, or hobbies.", 3, "Entertainment", 0.10m },
                    { 13, 3, 11, "Keep housing costs minimal where possible.", 3, "Rent or Mortgage", 0.20m },
                    { 14, 3, 11, "Electric, water, and internet essentials.", 3, "Utilities", 0.05m },
                    { 15, 3, 12, "Car payments, gas, or public transit.", 3, "Transportation", 0.10m },
                    { 16, 3, 13, "Weekly grocery trips only.", 1, "Groceries", 0.10m },
                    { 17, 3, 14, "Credit card, student loan, or auto debt reduction.", 3, "Debt Payments", 0.35m },
                    { 18, 3, 14, "Savings buffer for emergencies.", 3, "Emergency Fund", 0.10m },
                    { 19, 3, 15, "Household or personal essentials only.", 3, "Miscellaneous Essentials", 0.10m },
                    { 20, 4, 16, "Housing under 30% of total income.", 3, "Rent or Mortgage", 0.30m },
                    { 21, 4, 16, "Basic living needs (food, electricity, water).", 3, "Utilities & Groceries", 0.20m },
                    { 22, 4, 17, "Restaurants, movies, and leisure.", 3, "Dining & Entertainment", 0.20m },
                    { 23, 4, 17, "Trips, recreation, and other wants.", 3, "Travel & Hobbies", 0.10m },
                    { 24, 4, 18, "Loan or credit card payments.", 3, "Debt Payments", 0.10m },
                    { 25, 4, 18, "Long-term savings and retirement.", 3, "Savings & Investments", 0.10m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BudgetTemplates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BudgetTemplates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BudgetTemplates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BudgetTemplates",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CategoryTemplates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CategoryTemplates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CategoryTemplates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CategoryTemplates",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "CategoryTemplates",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "CategoryTemplates",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "CategoryTemplates",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "CategoryTemplates",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "CategoryTemplates",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "CategoryTemplates",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "CategoryTemplates",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "CategoryTemplates",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "CategoryTemplates",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "CategoryTemplates",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "CategoryTemplates",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "CategoryTemplates",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "CategoryTemplates",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "CategoryTemplates",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ExpenseTemplates",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ExpenseTemplates",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ExpenseTemplates",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ExpenseTemplates",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ExpenseTemplates",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ExpenseTemplates",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ExpenseTemplates",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ExpenseTemplates",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ExpenseTemplates",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ExpenseTemplates",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ExpenseTemplates",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ExpenseTemplates",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ExpenseTemplates",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ExpenseTemplates",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ExpenseTemplates",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ExpenseTemplates",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ExpenseTemplates",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ExpenseTemplates",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ExpenseTemplates",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ExpenseTemplates",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ExpenseTemplates",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ExpenseTemplates",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ExpenseTemplates",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ExpenseTemplates",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ExpenseTemplates",
                keyColumn: "Id",
                keyValue: 25);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using MyFi.Enums;
using MyFi.Models;

namespace MyFi.Data.Infrastructure.DataSeeders
{
    public static class BudgetTemplateSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // --- Budget Templates ---
            modelBuilder.Entity<BudgetTemplate>().HasData(
                new BudgetTemplate { Id = 1, Name = "Essential Living", Description = "A balanced starter budget covering everyday expenses.", Category = "General" },
                new BudgetTemplate { Id = 2, Name = "College Student", Description = "A lean, student-friendly budget for managing limited income.", Category = "Student" },
                new BudgetTemplate { Id = 3, Name = "High Debt Paydown", Description = "A focused budget to aggressively reduce debt while maintaining essential living costs.", Category = "Debt Management" },
                new BudgetTemplate { Id = 4, Name = "50/30/20 Rule", Description = "A simple, balanced budget based on the classic 50% needs, 30% wants, 20% savings model.", Category = "Balanced" }
            );

            // --- Category Templates ---
            modelBuilder.Entity<CategoryTemplate>().HasData(
                // Essential Living
                new CategoryTemplate { Id = 1, Name = "Housing", Description = "Mortgage or rent and home-related bills.", BudgetTemplateId = 1 },
                new CategoryTemplate { Id = 2, Name = "Utilities", Description = "Electricity, water, internet, phone, etc.", BudgetTemplateId = 1 },
                new CategoryTemplate { Id = 3, Name = "Transportation", Description = "Vehicle costs, gas, insurance, and maintenance.", BudgetTemplateId = 1 },
                new CategoryTemplate { Id = 4, Name = "Food", Description = "Groceries and dining out.", BudgetTemplateId = 1 },
                new CategoryTemplate { Id = 5, Name = "Savings & Debt", Description = "Debt payments, savings, or investments.", BudgetTemplateId = 1 },

                // College Student
                new CategoryTemplate { Id = 6, Name = "Housing", Description = "Dorm or apartment rent.", BudgetTemplateId = 2 },
                new CategoryTemplate { Id = 7, Name = "Food", Description = "Meal plan or groceries.", BudgetTemplateId = 2 },
                new CategoryTemplate { Id = 8, Name = "Education", Description = "Tuition, books, and course materials.", BudgetTemplateId = 2 },
                new CategoryTemplate { Id = 9, Name = "Transportation", Description = "Bus pass, car, or ride-sharing costs.", BudgetTemplateId = 2 },
                new CategoryTemplate { Id = 10, Name = "Leisure", Description = "Entertainment, hobbies, or outings.", BudgetTemplateId = 2 },

                // High Debt Paydown
                new CategoryTemplate { Id = 11, Name = "Housing", Description = "Essential housing expenses.", BudgetTemplateId = 3 },
                new CategoryTemplate { Id = 12, Name = "Transportation", Description = "Essential commuting or vehicle costs.", BudgetTemplateId = 3 },
                new CategoryTemplate { Id = 13, Name = "Food", Description = "Groceries only; minimal dining out.", BudgetTemplateId = 3 },
                new CategoryTemplate { Id = 14, Name = "Debt & Savings", Description = "Debt payoff and emergency reserves.", BudgetTemplateId = 3 },
                new CategoryTemplate { Id = 15, Name = "Miscellaneous", Description = "Basic personal and household needs.", BudgetTemplateId = 3 },

                // 50/30/20 Rule
                new CategoryTemplate { Id = 16, Name = "Needs", Description = "Essential bills, housing, and groceries.", BudgetTemplateId = 4 },
                new CategoryTemplate { Id = 17, Name = "Wants", Description = "Non-essential but enjoyable spending.", BudgetTemplateId = 4 },
                new CategoryTemplate { Id = 18, Name = "Savings & Debt", Description = "Savings, debt payments, and investments.", BudgetTemplateId = 4 }
            );

            // --- Expense Templates ---
            modelBuilder.Entity<ExpenseTemplate>().HasData(
                // Essential Living
                new ExpenseTemplate { Id = 1, Name = "Rent or Mortgage", Description = "Monthly rent or mortgage payment.", PercentageOfTotal = 0.30m, CategoryTemplateId = 1, BudgetTemplateId = 1, Frequency = ExpenseFrequency.Monthly },
                new ExpenseTemplate { Id = 2, Name = "Utilities", Description = "Electricity, water, and internet bills.", PercentageOfTotal = 0.10m, CategoryTemplateId = 2, BudgetTemplateId = 1, Frequency = ExpenseFrequency.Monthly },
                new ExpenseTemplate { Id = 3, Name = "Transportation", Description = "Fuel, maintenance, and insurance.", PercentageOfTotal = 0.15m, CategoryTemplateId = 3, BudgetTemplateId = 1, Frequency = ExpenseFrequency.Monthly },
                new ExpenseTemplate { Id = 4, Name = "Groceries", Description = "Weekly grocery shopping.", PercentageOfTotal = 0.15m, CategoryTemplateId = 4, BudgetTemplateId = 1, Frequency = ExpenseFrequency.Weekly },
                new ExpenseTemplate { Id = 5, Name = "Dining Out", Description = "Restaurants or takeout.", PercentageOfTotal = 0.05m, CategoryTemplateId = 4, BudgetTemplateId = 1, Frequency = ExpenseFrequency.Weekly },
                new ExpenseTemplate { Id = 6, Name = "Debt Payments", Description = "Credit card or loan payments.", PercentageOfTotal = 0.15m, CategoryTemplateId = 5, BudgetTemplateId = 1, Frequency = ExpenseFrequency.Monthly },
                new ExpenseTemplate { Id = 7, Name = "Emergency Savings", Description = "Set aside funds for emergencies.", PercentageOfTotal = 0.10m, CategoryTemplateId = 5, BudgetTemplateId = 1, Frequency = ExpenseFrequency.Monthly },

                // College Student
                new ExpenseTemplate { Id = 8, Name = "Rent", Description = "Dorm or apartment rent.", PercentageOfTotal = 0.35m, CategoryTemplateId = 6, BudgetTemplateId = 2, Frequency = ExpenseFrequency.Monthly },
                new ExpenseTemplate { Id = 9, Name = "Groceries", Description = "Food, snacks, or shared groceries.", PercentageOfTotal = 0.20m, CategoryTemplateId = 7, BudgetTemplateId = 2, Frequency = ExpenseFrequency.Weekly },
                new ExpenseTemplate { Id = 10, Name = "Tuition & Fees", Description = "Tuition, textbooks, and class materials.", PercentageOfTotal = 0.25m, CategoryTemplateId = 8, BudgetTemplateId = 2, Frequency = ExpenseFrequency.Yearly },
                new ExpenseTemplate { Id = 11, Name = "Transportation", Description = "Bus, fuel, or ride-share expenses.", PercentageOfTotal = 0.10m, CategoryTemplateId = 9, BudgetTemplateId = 2, Frequency = ExpenseFrequency.Monthly },
                new ExpenseTemplate { Id = 12, Name = "Entertainment", Description = "Movies, events, or hobbies.", PercentageOfTotal = 0.10m, CategoryTemplateId = 10, BudgetTemplateId = 2, Frequency = ExpenseFrequency.Monthly },

                // High Debt Paydown
                new ExpenseTemplate { Id = 13, Name = "Rent or Mortgage", Description = "Keep housing costs minimal where possible.", PercentageOfTotal = 0.20m, CategoryTemplateId = 11, BudgetTemplateId = 3, Frequency = ExpenseFrequency.Monthly },
                new ExpenseTemplate { Id = 14, Name = "Utilities", Description = "Electric, water, and internet essentials.", PercentageOfTotal = 0.05m, CategoryTemplateId = 11, BudgetTemplateId = 3, Frequency = ExpenseFrequency.Monthly },
                new ExpenseTemplate { Id = 15, Name = "Transportation", Description = "Car payments, gas, or public transit.", PercentageOfTotal = 0.10m, CategoryTemplateId = 12, BudgetTemplateId = 3, Frequency = ExpenseFrequency.Monthly },
                new ExpenseTemplate { Id = 16, Name = "Groceries", Description = "Weekly grocery trips only.", PercentageOfTotal = 0.10m, CategoryTemplateId = 13, BudgetTemplateId = 3, Frequency = ExpenseFrequency.Weekly },
                new ExpenseTemplate { Id = 17, Name = "Debt Payments", Description = "Credit card, student loan, or auto debt reduction.", PercentageOfTotal = 0.35m, CategoryTemplateId = 14, BudgetTemplateId = 3, Frequency = ExpenseFrequency.Monthly },
                new ExpenseTemplate { Id = 18, Name = "Emergency Fund", Description = "Savings buffer for emergencies.", PercentageOfTotal = 0.10m, CategoryTemplateId = 14, BudgetTemplateId = 3, Frequency = ExpenseFrequency.Monthly },
                new ExpenseTemplate { Id = 19, Name = "Miscellaneous Essentials", Description = "Household or personal essentials only.", PercentageOfTotal = 0.10m, CategoryTemplateId = 15, BudgetTemplateId = 3, Frequency = ExpenseFrequency.Monthly },

                // 50/30/20 Rule
                new ExpenseTemplate { Id = 20, Name = "Rent or Mortgage", Description = "Housing under 30% of total income.", PercentageOfTotal = 0.30m, CategoryTemplateId = 16, BudgetTemplateId = 4, Frequency = ExpenseFrequency.Monthly },
                new ExpenseTemplate { Id = 21, Name = "Utilities & Groceries", Description = "Basic living needs (food, electricity, water).", PercentageOfTotal = 0.20m, CategoryTemplateId = 16, BudgetTemplateId = 4, Frequency = ExpenseFrequency.Monthly },
                new ExpenseTemplate { Id = 22, Name = "Dining & Entertainment", Description = "Restaurants, movies, and leisure.", PercentageOfTotal = 0.20m, CategoryTemplateId = 17, BudgetTemplateId = 4, Frequency = ExpenseFrequency.Monthly },
                new ExpenseTemplate { Id = 23, Name = "Travel & Hobbies", Description = "Trips, recreation, and other wants.", PercentageOfTotal = 0.10m, CategoryTemplateId = 17, BudgetTemplateId = 4, Frequency = ExpenseFrequency.Monthly },
                new ExpenseTemplate { Id = 24, Name = "Debt Payments", Description = "Loan or credit card payments.", PercentageOfTotal = 0.10m, CategoryTemplateId = 18, BudgetTemplateId = 4, Frequency = ExpenseFrequency.Monthly },
                new ExpenseTemplate { Id = 25, Name = "Savings & Investments", Description = "Long-term savings and retirement.", PercentageOfTotal = 0.10m, CategoryTemplateId = 18, BudgetTemplateId = 4, Frequency = ExpenseFrequency.Monthly }
            );
        }
    }
}

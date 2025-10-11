using System.ComponentModel.DataAnnotations.Schema;
using MyFi.Enums;

namespace MyFi.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; } = 0.0m;

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        [ForeignKey("Budget")]
        public int BudgetId { get; set; }
        public ExpenseFrequency Frequency { get; set; } = ExpenseFrequency.Monthly;
    }

}

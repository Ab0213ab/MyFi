using MyFi.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFi.Models
{
    public class ExpenseTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;

        [Column(TypeName = "decimal(18,2)")]
        public decimal PercentageOfTotal { get; set; }

        [ForeignKey("CategoryTemplate")]
        public int CategoryTemplateId { get; set; }

        [ForeignKey("BudgetTemplate")]
        public int BudgetTemplateId { get; set; }
        public ExpenseFrequency Frequency { get; set; } = ExpenseFrequency.Monthly;
    }
}

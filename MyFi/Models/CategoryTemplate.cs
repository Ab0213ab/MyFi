using System.ComponentModel.DataAnnotations.Schema;

namespace MyFi.Models
{
    public class CategoryTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;

        [ForeignKey("BudgetTemplate")]
        public int BudgetTemplateId { get; set; }
    }
}

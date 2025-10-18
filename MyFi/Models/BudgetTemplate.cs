using System.ComponentModel.DataAnnotations.Schema;

namespace MyFi.Models
{
    public class BudgetTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Default Budget";
        public string Description { get; set; } = default!;
        public string Category { get; set; } = default!;
    }
}

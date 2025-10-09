using System.ComponentModel.DataAnnotations.Schema;

namespace MyFi.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; } = default!;
    }

}

using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFi.Models
{
    public class Budget
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Default Budget";
        public string Description { get; set; } = default!;

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }

        [BindNever]
        public string UserId { get; set; } = default!;
    }
}

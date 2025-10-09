namespace MyFi.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;

        public ICollection<Expense> Expenses { get; set; } = new List<Expense>();
    }
}

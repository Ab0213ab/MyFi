namespace MyFi.Models
{
    public class Expense
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public string Amount { get; set; } = default!;
    }

}

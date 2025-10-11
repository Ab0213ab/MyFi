namespace MyFi.Models
{
    public class Budget
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Default Budget";
        public string Description { get; set; } = default!;
    }
}

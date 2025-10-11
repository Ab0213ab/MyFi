using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFi.Models;

namespace MyFi.Pages.Budgets
{
    public class IndexModel : PageModel
    {
        private readonly MyFiDbContext _context;

        public IndexModel(MyFiDbContext context)
        {
            _context = context;
        }

        public List<Budget> Budgets { get; set; } = new();

        public void OnGet()
        {
            Budgets = _context.Budgets.ToList();
        }

        public int GetExpenseCount(int budgetId)
        {
            return _context.Expenses.Count(e => e.BudgetId == budgetId);
        }
    }
}

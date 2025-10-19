using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFi.Models;
using Microsoft.AspNetCore.Identity;

namespace MyFi.Pages.Budgets
{
    public class CreateModel : PageModel
    {
        private readonly MyFiDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public CreateModel(MyFiDbContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        [BindProperty]
        public Budget Budget { get; set; } = default!;

        public void OnGet() { }

        public async Task<IActionResult> OnPostAsync()
        {

            var user = await _userManager.GetUserAsync(User);
            Budget.UserId = user?.Id ?? string.Empty;

            // Clear the old model-state entry to validate
            // model state with the correct value
            ModelState.Remove("Budget.UserId");
            if (!ModelState.IsValid)
                return Page();

            _context.Budgets.Add(Budget);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}

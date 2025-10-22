using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyFi.Models;
using Microsoft.AspNetCore.Identity;

namespace MyFi.Pages.Budgets
{
    public class CreateModel : PageModel
    {
        private readonly ILogger<CreateModel> _logger;
        private readonly MyFiDbContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public CreateModel(ILogger<CreateModel> logger, MyFiDbContext context, UserManager<IdentityUser> userManager)
        {
            _logger = logger;
            _context = context;
            _userManager = userManager;
        }

        [BindProperty]
        public Budget Budget { get; set; } = default!;

        public void OnGet() 
        {
            _logger.LogInformation("Opened Create Budget page at {Time}", DateTime.UtcNow);
        }

        public async Task<IActionResult> OnPostAsync()
        {

            var user = await _userManager.GetUserAsync(User);
            Budget.UserId = user?.Id ?? string.Empty;

            // Clear the old model-state entry to validate
            // model state with the correct value
            ModelState.Remove("Budget.UserId");
            if (!ModelState.IsValid)
            {
                _logger.LogWarning("Invalid budget submission: {@Budget}", Budget);
                return Page();
            }

            try
            {
                _context.Budgets.Add(Budget);
                _context.SaveChanges();
                _logger.LogInformation("Successfully created budget: {@Budget}", Budget);
                return RedirectToPage("/Budgets/Index");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating budget: {@Budget}", Budget);
                ModelState.AddModelError("", "An error occurred while creating the budget.");
                return Page();
            }

            //_context.Budgets.Add(Budget);
            //await _context.SaveChangesAsync();

            //return RedirectToPage("Index");
        }
    }
}

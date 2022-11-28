using EmployeesRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace EmployeesRazor.Pages.Employees
{
    public class CreateModel : PageModel
    {
        private AppDbContext _db;

        public CreateModel(AppDbContext db)
        {
            _db= db;
        }

        [BindProperty]
        public Employee Employee { get; set; }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.Employees.AddAsync(Employee);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}

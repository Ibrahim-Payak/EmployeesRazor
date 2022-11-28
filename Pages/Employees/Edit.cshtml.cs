using EmployeesRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace EmployeesRazor.Pages.Employees
{
    public class EditModel : PageModel
    {
        private AppDbContext _db;

        public EditModel(AppDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Employee Employee { get; set; }
        public async Task OnGet(int id)
        {
            Employee = await _db.Employees.FindAsync(id);
        }


        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var EmployeeDb = await _db.Employees.FindAsync(Employee.Id);
                EmployeeDb.Name = Employee.Name;
                EmployeeDb.Salary = Employee.Salary;
                EmployeeDb.Post = Employee.Post;

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

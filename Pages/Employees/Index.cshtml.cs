using EmployeesRazor.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EmployeesRazor.Pages.Employees
{
    public class IndexModel : PageModel
    {

        public readonly AppDbContext _db;

        public IndexModel(AppDbContext db)
        {
            _db = db;
        }

        public IEnumerable<Employee> vs { get; set; }
        public async Task OnGet()
        {
            vs = await _db.Employees.ToListAsync();
        }

        public async Task<IActionResult> OnDelete(int id)
        {
            var bookFound = await _db.Employees.FindAsync(id);
            if (bookFound == null)
            {
                return NotFound();
            }

            else
            {
                _db.Employees.Remove(bookFound);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
        }
    }
}

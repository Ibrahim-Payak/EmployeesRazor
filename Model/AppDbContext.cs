using Microsoft.EntityFrameworkCore;

namespace EmployeesRazor.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option)
        {

        }

        public DbSet<Employee> Employees { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace EmployeesRazor.Model
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        public string Name { get; set; }
        public string Salary { get; set; }
        public string Post { get; set; }

        
    }
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EmployeeManagement.Models
{
    public class Department
    {

        [Key]
        public int DepartmentId { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public string? DepartmentName { get; set; }

        [ForeignKey("Employee")]
        [Display(Name = "Employee ID")]
        public int EmployeeId { get; set; }

        public Employee? Employee { get; set; }
    }
}

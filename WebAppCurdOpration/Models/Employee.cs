using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppCurdOpration.Models
{
    [Table("Employees",Schema ="HR")]
    public class Employee
    {
        [Key]
        [Display(Name ="رقم الموظف")]
        public int? EmployeeId { get; set; }

        [Required]
        [Display(Name = "اسم الموظف")]
        [Column(TypeName ="nvarchar(200)")]
        public string EmployeeName { get; set; } = String.Empty;

        [Display(Name ="Image User")]
        [Column(TypeName = "varchar(250)")]
        public string? ImageUser { get; set; }

        [Display(Name ="Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Salary")]
        [Column(TypeName ="decimal(12,2)")]
        public decimal Salary { get; set; }

        [Display(Name = "Hiring Date")]
        [DataType(DataType.Date)]
       // [DisplayFormat(DataFormatString = "0:dd-MMMM-yyyy")]
        public DateTime HiringDate { get; set; }

        [Required]
        [Display(Name ="National ID")]
        [MaxLength(14)]
        [MinLength(14)]
        [Column(TypeName ="varchar(14)")]
        public string NationalId { get; set; }  

        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public Departmen? Department { get; set; }








    }
}

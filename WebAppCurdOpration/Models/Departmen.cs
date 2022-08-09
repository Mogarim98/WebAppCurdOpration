﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAppCurdOpration.Models
{
    [Table("Departments",Schema ="HR")]
    public class Departmen
    {
        [Key]
        [Display(Name ="ID")]
        public int DepartmentId { get; set; }

        [Required]
        [Display(Name ="Department Name")]
        [Column(TypeName="nvarchar(200)")]
        public string DepartmentName { get; set; } = String.Empty;

    }
}

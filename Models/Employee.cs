using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWepAPI2.Models
{
    public partial class Employee
    {
        [Key]
        [Column("EmployeeID")]
        public int? EmployeeId { get; set; }
        [StringLength(50)]
        public string? Name { get; set; }
        [StringLength(50)]
        public string? Position { get; set; }
        public int? Age { get; set; }
        public int? Salary { get; set; }
    }
}

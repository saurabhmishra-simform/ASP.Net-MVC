using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    [Table("Employee")]
    public class EmployeeModel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public double? Salary { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public DateTime? DateOfJoining { get; set; } 
    }
}
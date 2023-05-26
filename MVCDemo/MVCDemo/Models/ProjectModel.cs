using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    [Table("Projects")]
    public class ProjectModel
    {
        [Key]
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public int ClientId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [ForeignKey("Employee")]
        public int? EmployeeId { get; set; }
        public virtual EmployeeModel Employee { get; set; }
    }
}
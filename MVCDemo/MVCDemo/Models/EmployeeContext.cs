using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class EmployeeContext : DbContext
    {
        public DbSet<EmployeeModel> Employees { get; set;}
        public DbSet<ProjectModel> Projects { get; set;}
    }
}
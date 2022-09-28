using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmpSearch.Models
{
    public class EmpContext : DbContext
    {
        public EmpContext() : base("EmpContext")
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
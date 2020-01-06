using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CURD.Models
{
    public class EmployeeContext: DbContext
    {

        public EmployeeContext(DbContextOptions<EmployeeContext> options): base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Match> Matchs { get; set; }

    }
}

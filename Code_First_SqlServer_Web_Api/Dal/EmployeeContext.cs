using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Code_First_SqlServer_Web_Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Code_First_SqlServer_Web_Api.Dal
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options) : base(options) { }

        // call the class of Employee.cs
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(new Employee
            {
                EmployeeId = 1,
                FirstName = "Owamamwen",
                LastName = "Ogunniyi",
                Gender = 'M',
                Email = "owamamwen@outlook.com",
                DataOfBirth = new DateTime(1991, 12, 11),
                PhoneNumber = "351-045-9350"
            }, new Employee
            {
                EmployeeId = 2,
                FirstName = "Federica",
                LastName = "Dario",
                Gender = 'F',
                Email = "fede@gmail.com",
                DataOfBirth = new DateTime(1973, 07, 21),
                PhoneNumber = "351-105-0380"
            });
        }
    }
}

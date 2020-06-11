﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tcb.model;

namespace tcb.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {
                
        }
        public DbSet<Employee> Employees { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1, Name = "Mark", Email = "MArk@gmail.com", Department = Dept.Payroll
                },
                new Employee
                {
                Id = 2, Name = "shivu", Email = "shivu@gmail.com", Department = Dept.IT
                }
                );
        }
    }
}

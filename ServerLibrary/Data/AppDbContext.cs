﻿

using BaseLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace ServerLibrary.Data
{
    public class AppDbContext(DbContextOptions options) : DbContext(options)
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<GeneralDepartment> GeneralDepartment { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<Town> Town { get; set; }

        public DbSet<Users> Users { get; set; }

     
    }
}

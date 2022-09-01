using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace StudentPortalAdmin.API.DataModel
{
    public class StudentAdminContext : DbContext
    {
        public StudentAdminContext(DbContextOptions<StudentAdminContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}


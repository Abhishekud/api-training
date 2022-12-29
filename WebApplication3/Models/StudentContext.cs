using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class StudentContext : DbContext
    {
        public StudentContext() : base("DefaultConnection") { }

        public DbSet<Student> Students { get; set;}
        public DbSet<Subject> Subjects { get; set; }

    }
}
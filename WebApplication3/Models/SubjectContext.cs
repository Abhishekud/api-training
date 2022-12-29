using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class SubjectContext : DbContext
    {
        public SubjectContext() : base("DefaultConnection") { }

        public DbSet<Student> Students { get; set;}
        public DbSet<Subject> Subjects { get; set; }

    }
}
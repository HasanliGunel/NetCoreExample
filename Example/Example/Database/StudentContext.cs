using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example.Database
{
    public class StudentContext:DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> context) : base(context) { }
        public DbSet<Student> Students { get; set; }

    }
}

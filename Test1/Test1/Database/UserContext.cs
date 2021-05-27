using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test1.Database
{
    public class UserContext:DbContext
    {
        public UserContext(DbContextOptions<UserContext> context) : base(context) { }
        public DbSet<User> Users { get; set; }
        public DbSet<UserGender> UserGenders { get; set; }
    }
}

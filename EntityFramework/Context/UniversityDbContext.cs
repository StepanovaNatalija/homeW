using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    public class UniversityDbContext : DbContext
    {
        public DbSet<Students> Students { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlServer(@"Server=LAPTOP-20BVNTSH\SQLEXPRESS; Database=UniversityDB; Trusted_Connection=True;");
    }
}

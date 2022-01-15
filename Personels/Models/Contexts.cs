using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Personels.Models
{
    public class Contexts:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=ARGE-01; database=ozekin; integrated security=true;");
        }

        public DbSet<Personel> Personels { get; set; }
        public DbSet<Birim> Birims { get; set; }
    }
}

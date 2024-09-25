using Datalar.Enttites;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalar
{
    public class AppContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-I4PRRNC\\SQLEXPRESS;Database=Test;Trusted_Connection=true;");
        }
        public DbSet<Sinifler> Sinifler { get; set; }
        public DbSet<Telebeler> Telebeler { get; set; }
    }


}

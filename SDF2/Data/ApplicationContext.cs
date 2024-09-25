using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ApplicationContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-I4PRRNC\\SQLEXPRESS;Database=UserRegister;Trusted_Connection=true;");
        }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<Grup> Grups { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}

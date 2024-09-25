using Data.Entities;
using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ApplicationContext:DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("server=DESKTOP-I4PRRNC\\SQLEXPRESS;Database=sdf2numune;Trusted_Connection=true;");
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-I4PRRNC\\SQLEXPRESS;Database=KenanNihat;Trusted_Connection=true;");
        }
        public DbSet<UserModel> users { get; set; } 
        public DbSet<Grup> Grups { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}

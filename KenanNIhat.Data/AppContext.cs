using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KenanNIhat.Data
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions<AppContext> options):base(options)
        {
            
        }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Students> Students { get; set; }


    }
}

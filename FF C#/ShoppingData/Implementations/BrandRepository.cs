using ShoppingData.Contracts;
using ShoppingData.DAL;
using ShoppingData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingData.Implementations
{
    public class BrandRepository : GenericRepository<Brands>, IBrandRepository
    {
        public BrandRepository(DatabaseContext context) : base(context)
        {
        }
    }
}

using Microsoft.EntityFrameworkCore;
using ShoppingData.Contracts;
using ShoppingData.DAL;
using ShoppingData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingData.Implementations
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(DatabaseContext context) : base(context)
        {
        }

        public List<Product> GetAllProductsByCategory(int CategoryId)
        {
           return _context.Products.Where(x=>x.CategoriesId==CategoryId).Include(x=>x.Brand).ToList();
        }
        public List<Product> GetAllProductsWithBrands()
        {
            return _context.Products.Include(x => x.Brand).ToList();
        }
        public Product GetById(int id)
        {
            return _context.Products.FirstOrDefault(x => x.Id == id);
        }
    }
}

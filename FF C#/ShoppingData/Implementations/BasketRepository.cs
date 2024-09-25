using Microsoft.EntityFrameworkCore;
using ShoppingData.Contracts;
using ShoppingData.DAL;
using ShoppingData.DTOs;
using ShoppingData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingData.Implementations
{
    public class BasketRepository : GenericRepository<Basket>, IBasketRepository
    {
        public BasketRepository(DatabaseContext context) : base(context)
        {
        }

        public void DeleteAll()
        {
            foreach (var basket in _context.Baskets)
            {
                _context.Baskets.Remove(basket);
            }
            _context.SaveChanges();
        }
        
        public List<Basket> GetAllBaskets()
        {
            return _context.Baskets.Include(x => x.Product).ThenInclude(x => x.Brand).ToList();
               
        }
    }
}

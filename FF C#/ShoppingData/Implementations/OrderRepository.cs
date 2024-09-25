using Microsoft.EntityFrameworkCore;
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
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        public OrderRepository(DatabaseContext context) : base(context)
        {
        }

        public void DeleteAllOrders()
        {
            foreach (var order in _context.Orders)
            {
                _context.Remove(order);
            }
        }

        public List<Order> GetAllOrdersWithJoins()
        {
            return _context.Orders.Include(x=>x.OrderProducts).ThenInclude(x=>x.Product).ToList();
        }
    }
}

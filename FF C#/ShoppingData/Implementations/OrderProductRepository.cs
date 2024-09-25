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
    public class OrderProductRepository : GenericRepository<OrderProduct>, IOrderProductRepository
    {
        public OrderProductRepository(DatabaseContext context) : base(context)
        {
        }

        public void DeletAllOrderProducts()
        {
                foreach (var order in _context.OrderProducts)
                {
                    _context.Remove(order);
                }
        }

        public List<OrderDTO> GetAllOrders()
        {
            List<OrderDTO> orders = new List<OrderDTO>();
            List<OrderProduct> orderProducts = _context.OrderProducts.Include(x=>x.Order).Include(x=>x.Product).ToList();
            foreach (var orderProduct in orderProducts)
            {
                orders.Add(new OrderDTO
                {
                    Id = orderProduct.Id,
                    UserName = orderProduct.Order.UserName,
                    Adress = orderProduct.Order.Adress,
                    Email = orderProduct.Order.Email,
                    Date = orderProduct.Order.Date,
                    PayMethod = orderProduct.Order.PayMethod,
                    PhoneNumber = orderProduct.Order.PhoneNumber,
                    ProductCount = orderProduct.ProductCount,
                    ProductName = orderProduct.ProductName,
                });
            }
            return orders;
        }
    }
}

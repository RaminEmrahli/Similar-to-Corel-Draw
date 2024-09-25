using ShoppingData.DTOs;
using ShoppingData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingData.Contracts
{
    public interface IOrderProductRepository:IGenericRepository<OrderProduct>
    {
        List<OrderDTO> GetAllOrders();
        void DeletAllOrderProducts();
    }
}

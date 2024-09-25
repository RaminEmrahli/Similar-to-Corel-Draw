using ShoppingData.DTOs;
using ShoppingData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingData.Contracts
{
    public interface IBasketRepository:IGenericRepository<Basket>
    {
        List<Basket> GetAllBaskets();
        void DeleteAll();
    }
}

using ShoppingData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingData.Contracts
{
    public interface IProductRepository:IGenericRepository<Product>
    {
        List<Product> GetAllProductsByCategory(int CategoryId);
        List<Product> GetAllProductsWithBrands();
        Product GetById(int Id);
    }
}

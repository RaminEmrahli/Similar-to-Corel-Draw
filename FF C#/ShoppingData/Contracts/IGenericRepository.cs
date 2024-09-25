using ShoppingData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingData.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> GetAll();
        void Add(T model);
        void Save();        
    }
}

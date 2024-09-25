using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        public List<T> GetAll();
        public void Add(T model);
        public void Save();
    }
}

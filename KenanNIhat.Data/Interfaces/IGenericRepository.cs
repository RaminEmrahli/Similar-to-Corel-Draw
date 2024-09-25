using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KenanNIhat.Data.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        public List<T> GetAll();
        public void Add(T model);
        public void Save();
    }
}

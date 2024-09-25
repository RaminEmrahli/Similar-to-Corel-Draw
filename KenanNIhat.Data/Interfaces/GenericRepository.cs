using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KenanNIhat.Data.Interfaces
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly AppContext _context;
        public GenericRepository(AppContext context)
        {
            _context = context;
        }

        public void Add(T model)
        {
            _context.Set<T>().Add(model);
        }

        public List<T> GetAll()
        {
            return _context.Set<T>().ToList();
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}

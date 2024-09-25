using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalar
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        protected readonly AppContext _context;
        public GenericRepository(AppContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
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

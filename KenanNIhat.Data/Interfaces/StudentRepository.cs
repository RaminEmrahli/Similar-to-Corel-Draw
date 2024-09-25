using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KenanNIhat.Data.Interfaces
{
    public class StudentRepository : GenericRepository<Students>, IStudentRepository
    {
        public StudentRepository(AppContext context) : base(context)
        {
        }
    }
}

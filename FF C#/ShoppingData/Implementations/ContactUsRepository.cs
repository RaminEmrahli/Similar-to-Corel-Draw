using ShoppingData.Contracts;
using ShoppingData.DAL;
using ShoppingData.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingData.Implementations
{
    public class ContactUsRepository : GenericRepository<ContactUs>, IContactUsRepository
    {
        public ContactUsRepository(DatabaseContext context) : base(context)
        {
        }
    }
}

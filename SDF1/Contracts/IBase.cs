using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDF1.Contracts
{
    internal interface IBase<T>
    {
        void Add(T model);
        List<T> GetAll();
        int Count();
    }
}

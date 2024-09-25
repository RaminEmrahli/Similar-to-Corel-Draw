using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datalar
{
    public class ErrorBase
    {
        string filepath = @"C:\Users\Ramin\OneDrive\Masaüstü\error.txt";
        public void Logging(string message)
        {
            File.WriteAllText(filepath, message);
        }
    }
}

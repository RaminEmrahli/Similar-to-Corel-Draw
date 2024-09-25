using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class ErrorModel
    {
        public string filePath = @"C:\Users\Ramin\OneDrive\Masaüstü\error.txt";
        public void Logging(string message)
        {
            File.WriteAllText(filePath, message);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KenanNIhat.Data.Interfaces
{
    public class ErrorsRepository
    {
        public string FilePath = @"C:\Users\Ramin\OneDrive\Masaüstü\exceptions.txt";
        public void Logging(string message)
        {
            File.WriteAllText(FilePath, message);
        }
    }
}

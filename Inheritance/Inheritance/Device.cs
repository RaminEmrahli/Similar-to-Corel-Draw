using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal abstract class Device
    {
        public string Name { get; set; }

        public Device()
        {
            Console.WriteLine("Device added:");
        }
        public Device(string name):this()
        {
            Name = name;
        }
        public abstract string GetChargeTypeName();
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Computer:Device
    {
        public string Charger { get; set; }
        public Computer(string name, string chargerName) : base(name)
        {
            Name = name;
            Charger = chargerName;
        }
        public override string GetChargeTypeName()
        {
            return $"{this.Name} zaryatkani {Charger} ile yigir";    
        }
    }
}

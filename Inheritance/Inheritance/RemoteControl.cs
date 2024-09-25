using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class RemoteControl:Device
    {
        public string Charger { get; set; }
        public RemoteControl(string name, string chargerName) : base(name)
        {
            Name = name;
            Charger = chargerName;
        }
        public override string GetChargeTypeName()
        {
            return $"{Charger} ile isleyir";
        }
    }
}

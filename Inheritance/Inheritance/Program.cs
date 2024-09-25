using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Phone phn= new Phone("Phone","adapter");
            Console.WriteLine(phn.GetChargeTypeName());

            RemoteControl rmt = new RemoteControl("Phone", "Batareya");
            Console.WriteLine(rmt.GetChargeTypeName());

            Computer comp = new Computer("Phone", "adapter");
            Console.WriteLine(comp.GetChargeTypeName());

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingData.Entities
{
    public class Basket
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int ProductCount { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingData.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public int SoldCount { get; set; }
        public string Image { get; set; }
        public int BrandId { get; set; }
        public Brands Brand { get; set; }
        public int CategoriesId { get; set; }
        public Categories Category { get; set; }
    }
}

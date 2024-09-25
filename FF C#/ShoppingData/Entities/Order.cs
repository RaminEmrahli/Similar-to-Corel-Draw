using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingData.Entities
{
    public class Order
    {
        public int Id { get; set; }   
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public double Total { get; set; }
        public string PayMethod { get; set; }
        public DateTime Date { get; set; }
        public List<OrderProduct>? OrderProducts { get; set; } = new List<OrderProduct>();
    }
}

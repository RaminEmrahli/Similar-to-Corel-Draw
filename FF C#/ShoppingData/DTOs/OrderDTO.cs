using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingData.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Adress { get; set; }
        public string PayMethod { get; set; }
        public int ProductCount { get; set; }
        public string ProductName { get; set; }
        public DateTime Date { get; set; }

    }
}

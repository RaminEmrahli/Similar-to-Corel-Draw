using Newtonsoft.Json;
using SDF1.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDF1
{
    static class Database
    {
        public static string PathOrder = @"C:\Users\Ramin\OneDrive\Masaüstü\Order.json";
        public static string PathProduct = @"C:\Users\Ramin\OneDrive\Masaüstü\Product.json";

        public static List<ProductModel> Products = new List<ProductModel>();
        public static List<OrdersModel> Orders = new List<OrdersModel>();

        //public static void LoadData()
        //{
        //    string json = "";
        //    using (StreamReader reader = new StreamReader(PathProduct))
        //    {
        //        json = reader.ReadToEnd();
        //    }
        //    Products = JsonConvert.DeserializeObject<List<ProductModel>>(json);
        //    json = "";
        //    using (StreamReader reader = new StreamReader(PathOrder))
        //    {
        //        json = reader.ReadToEnd();
        //    }
        //    Orders = JsonConvert.DeserializeObject<List<OrdersModel>>(json);
        //}



    }
}

using Newtonsoft.Json;
using SDF1.Contracts;
using SDF1.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDF1.Repositories
{
    public class OrdersRepositories : IBase<OrdersModel>
    {
        public int Count()
        {
            return Database.Orders.Count();
        }

        public List<OrdersModel> GetAll()
        {
            return Database.Orders;// Student.json Read
        }

        public void Add(OrdersModel model)
        {
            Database.Orders.Add(model);// Student.json Write

            var json = JsonConvert.SerializeObject(Database.Orders);
            using (StreamWriter sw = new StreamWriter(Database.PathOrder)) //path
            {
                sw.WriteLine(json);
            }
        }
    }
}

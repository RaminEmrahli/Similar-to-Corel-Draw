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
    public class ProductsRepository:IBase<ProductModel>
    {

        public int Count()
        {
            return Database.Products.Count();
        }

        public List<ProductModel> GetAll()
        {
            return Database.Products;// Student.json Read
        }

        public void Add(ProductModel model)
        {
            Database.Products.Add(model);// Student.json Write

            var json = JsonConvert.SerializeObject(Database.Products);
            using (StreamWriter sw = new StreamWriter(Database.PathProduct)) //path
            {
                sw.WriteLine(json);
            }
        }

    }
}

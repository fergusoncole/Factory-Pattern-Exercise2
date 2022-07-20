using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory__Pattern__Exercise2
{
    internal class SQLDataAccess : IDataAccess
    {
        public List<Product> LoadData()
        {
            Console.WriteLine("Loading data into a SQL Database");
            var product1 = new Product()
            {
                Name = "Macbook",
                Price = 2800.99
            };
            var product2 = new Product()
            {
                Name = "Dell",
                Price = 2500.83
            };
            var product3 = new Product()
            {
                Name = "Asus",
                Price = 2479.83

            };
            return new List<Product>() { product1, product2, product3 };
        }

        public void SaveData()
        {
            Console.WriteLine("Saving data into a SQL Database");
        }
    }
}

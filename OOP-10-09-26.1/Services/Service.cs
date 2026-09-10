using OOP_10_09_26._1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_10_09_26._1.Services
{
    public class Service : IService
    {
        List<Product> Products;
        Random rdn;

        public Service()
        {
            Products = new List<Product>();
            rdn = new Random();
        }

        public void Display()
        {
            foreach (var item in Products)
            {
                Console.WriteLine($"{item.ID,5} {item.Name,10} {item.Price,5} {item.B1,4} {item.B2,4} {item.B3,4}");
            }
        }

        public void Mock(int num = 5)
        {
            for (int i = 0; i < num; i++)
            { 
                var prod = new Product()
                {
                    ID = "P00" + i,
                    Name = "Product " + i,
                    Price = rdn.Next(100, 5001),
                    B1 = rdn.Next(0, 21),
                    B2 = rdn.Next(0, 21),
                    B3 = rdn.Next(0, 21)
                };
                Products.Add(prod);
            }
        }
    }
}

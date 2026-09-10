using OOP_10_09_26._1.Models;
using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
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
            Console.WriteLine($"{"ID",5} {"Name",10} {"Price",5} " +
                $"{"B1",4} {"B2",4} {"B3",4} {"Total",6} {"Value",12:N0}");

            Console.WriteLine(new string('-', 60));

            foreach (var item in Products)
            {
                Console.WriteLine($"{item.ID,5} {item.Name,10} {item.Price,5} " +
                    $"{item.B1,4} {item.B2,4} {item.B3,4} {item.Total(),6} {item.Value(),12:N0}");
            }

            var SumB1 = Products.Sum(p => p.B1);
            var SumB2 = Products.Sum(p => p.B2);
            var SumB3 = Products.Sum(p => p.B3);
            var SumTotal = Products.Sum(p => p.Total());
            var SumVal = Products.Sum(p => p.Value());
            Console.WriteLine($"{"TOTAL",5} {SumB1, 21} {SumB2, 4} {SumB3, 4} " +
                $"{SumTotal,6} {SumVal,12:N0}");

            Console.WriteLine();

            var maxTotal = Products.Max(p => p.Total());
            var maxProducts = Products.Where(p => p.Total() == maxTotal).ToList();

            var minTotal = Products.Min(p => p.Total());
            var minProducts = Products.Where(p => p.Total() == minTotal).ToList();

            Console.Write($"Max Stock Product {maxTotal}");
            foreach (var item in maxProducts)
            {
                Console.Write($" {item.Name}");
            }

            Console.WriteLine();
            
            Console.Write($"Min Stock Product {minTotal}");
            foreach (var item in minProducts)
            {
                Console.Write($" {item.Name}");
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

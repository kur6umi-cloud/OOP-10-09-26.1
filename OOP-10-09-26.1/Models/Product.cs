using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_10_09_26._1.Models
{
    public class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int B1 { get; set; }
        public int B2 { get; set; }
        public int B3 { get; set; }

        public double Total() => B1 * B2 + B3;
        public double Value() => Total() * (double)Price;
    }
}

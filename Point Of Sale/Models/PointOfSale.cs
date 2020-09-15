using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PointOfSale.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Ratings { get; set; }
    }
    public class Buyer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public double ProductsInInventory { get; set; }
        public decimal Price { get; set; }
    }
    public class Seller
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public String Age { get; set; }
        public double AmountInAccount { get; set; }

    }
    

}
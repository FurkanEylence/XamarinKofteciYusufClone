using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinKofteciYusufClone.Models
{
    public class Product
    {
        public int Id  { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
    }
}

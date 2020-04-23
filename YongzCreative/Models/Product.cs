using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace YongzCreative.Models
{
    public enum Category { Cap, Hoodie, Sweater, T_Shirt, Sweatpants, Leggings };
    public class Product
    {
        public int ProductId { get; set; }        public string Name { get; set; }        public string Description { get; set; }        public string ImagePath { get; set; }
        public decimal Price { get; set; }
        public Category category { get; set; }
    }
}
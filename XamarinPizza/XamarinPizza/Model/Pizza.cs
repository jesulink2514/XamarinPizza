using System;
using System.Collections.Generic;
using System.Text;

namespace XamarinPizza.Model
{
    public class Pizza
    {
        public int id { get; set; }
        public string name { get; set; }
        public float basePrice { get; set; }
        public string description { get; set; }
        public string imageUrl { get; set; }
    }
}

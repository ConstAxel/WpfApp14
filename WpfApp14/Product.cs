using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp14
{
    public enum Categories
    {
        Food,
        Appliances
    }
    public class Product
    {
        public string NameProduct { get; set; }
        public int PriceProduct { get; set; }
        public string ImageProduct { get; set; }
        public Categories CategoryProduct { get; set; }
    }
}

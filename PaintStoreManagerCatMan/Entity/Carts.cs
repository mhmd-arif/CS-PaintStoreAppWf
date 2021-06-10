using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintStoreManagerCatMan.Entity
{
    class Carts
    {
        // Properties
        public int Id { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public double SellPrice { get; set; }

        // constructor

        public Carts()
        {

        }

        public Carts(int id, string ctg, string nama, string color, string size, double sp)
        {
            Id = id;
            Category = ctg;
            Brand = nama;
            Color = color;
            Size = size;
            SellPrice = sp;
        }
    }
}

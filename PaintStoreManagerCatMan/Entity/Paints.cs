using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintStoreManagerCatMan.Entity
{
    class Paints
    {
        // Properties

        public int Id { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
        public int Quantity { get; set; }
        public double BuyPrice { get; set; }
        public double SellPrice { get; set; }

        // constructor

        public Paints()
        {

        }

        public Paints(int id, string ctg,string nama, string color, string size, int qty, double bp, double sp )
        {
            Id = id;
            Category = ctg;
            Brand = nama;
            Color = color;
            Size = size;
            Quantity = qty;
            BuyPrice = bp;
            SellPrice = sp;
        }
    }
}

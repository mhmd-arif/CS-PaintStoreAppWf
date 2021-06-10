using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintStoreManagerCatMan.Entity
{
    class Transaction
    {
        public int Id { get; set; }
        public double Ammount { get; set; }

        public Transaction()
        {

        }
        public Transaction(int id, double ammount)
        {
            Id = id;
            Ammount = ammount;
        }
    }
}

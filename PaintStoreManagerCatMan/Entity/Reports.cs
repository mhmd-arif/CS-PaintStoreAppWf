using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintStoreManagerCatMan.Entity
{
    class Reports
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public string Cashier { get; set; }
        public double Cash { get; set; }
        public double Transaction { get; set; }
        public double Change { get; set; }
        public string Date { get; set; }

        public Reports()
        {

            
        }
        public Reports(int id, string customer, string cashier, double cash, double transaction, double change, string date)
        {
            Id = id;
            Customer = customer;
            Cashier = cashier;
            Cash = cash;
            Transaction = transaction;
            Change = change;
            Date = date;


        }
    }
}

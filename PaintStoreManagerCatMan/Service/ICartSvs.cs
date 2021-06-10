using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintStoreManagerCatMan.Entity;

namespace PaintStoreManagerCatMan.Service
{
    interface ICartSvs
    {

        List<Carts> GetAllCarts();
        void Add(string nama, string color, string ctg, string size, double sp);
        void Update(int id, string nama, string color, string ctg, int qty, double sp);
        void Delete(int id);
    }
}

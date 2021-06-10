using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintStoreManagerCatMan.Entity;

namespace PaintStoreManagerCatMan.Service
{
    interface ICategorySvs
    {
        List<Category> GetAllCategories();
        void Add(string catname, string catdesc);
        void Update(int id, string catname, string catdesc);
        void Delete(int id);
    }
}

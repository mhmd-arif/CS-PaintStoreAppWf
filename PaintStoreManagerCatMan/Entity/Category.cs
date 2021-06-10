using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintStoreManagerCatMan.Entity
{
    class Category
    {
        // properties
        public int Id { get; set; }
        public string CateName { get; set; }
        public string CateDesc { get; set; }


        // constructor
        public Category()
        {

        }
        public Category(int id, string name, string desc)
        {
            Id = id;
            CateName = name;
            CateDesc = desc;
        }

    }
}

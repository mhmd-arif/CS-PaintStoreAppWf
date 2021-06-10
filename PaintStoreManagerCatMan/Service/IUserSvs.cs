using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaintStoreManagerCatMan.Entity;

namespace PaintStoreManagerCatMan.Service
{
    interface IUserSvs
    {
        List<User> GetAllUser();
        void Add(string name, string username, string pass, string level);
        void Update(int id, string name, string username, string pass, string level);
        void Delete(int id);
    }
}

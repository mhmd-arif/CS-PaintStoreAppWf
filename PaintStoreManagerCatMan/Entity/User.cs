using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintStoreManagerCatMan.Entity
{
    class User
    {
        // Properties

        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Level  { get; set; }


        // Constructor

        public User()
        {

        }
        public User(int id,string name, string user, string pass, string level)
        {
            Id = id;
            Username = user;
            Password = pass;
            Level = level;
        }
    }
}

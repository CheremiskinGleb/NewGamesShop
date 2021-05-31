using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShop.Model
{
    public class User
    {
        public User()
        {
            Nickname = "Nickname";
            Login = "Login";
            Password = "Password";
            Telephone = "Telephone";
        }
        public int UserId { get; set; }
        public string Nickname { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Telephone { get; set; }
    }
}

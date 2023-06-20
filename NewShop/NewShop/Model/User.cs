using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShop.Model
{
    public class AspNetUser : IdentityUser<string>
    {
        public int Wallet { get; set; }
    }
}

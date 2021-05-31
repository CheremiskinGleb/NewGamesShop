﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShop.Model
{
    [Keyless]
    public class UserLibrary
    {
        public UserLibrary()
        {
        }
        public int GameId { get; set; }
        public string UserId { get; set; }
    }
}

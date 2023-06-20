using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using System;

namespace NewShop.Model
{
    [Keyless]
    public class AspNetUserRoles
    {
        public string UserId { get; set; }

        public string RoleId { get; set; }
    }
}

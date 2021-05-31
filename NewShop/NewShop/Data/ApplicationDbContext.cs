using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using NewShop.Model;

namespace NewShop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Games> Games { get; set; }
        public DbSet<UserLibrary> UserLibrary { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
    }
}

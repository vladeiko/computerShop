using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace ComputerShop
{
    class MyDbContext : DbContext
    {
        public MyDbContext()
            : base("DbConnectionString")
        { }

        public DbSet<User> Users { get; set; }
    }
}
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
        public DbSet<Computer> Computers { get; set; }
        public DbSet<Processor> Processors { get; set; }
        public DbSet<Videocard> Videocards { get; set; }
        public DbSet<RAM> RAMs { get; set; }
    }
}
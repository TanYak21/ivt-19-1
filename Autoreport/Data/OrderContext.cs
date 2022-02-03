﻿using System.Data.Entity;
using Autoreport.Models;

namespace Autoreport.Context
{
    class OrderContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Genre> DopositType { get; set; }
        public DbSet<Deposit> Deposits { get; set; }
        // ...
    }
}

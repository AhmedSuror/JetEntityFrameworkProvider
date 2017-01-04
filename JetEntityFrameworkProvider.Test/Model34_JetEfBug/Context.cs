﻿using System.Data.Common;
using System.Data.Entity;

namespace JetEntityFrameworkProvider.Test.Model34_JetEfBug
{
    public class DataContext : DbContext
    {
        public DataContext(DbConnection connection) : base(connection, false) { }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }
    }
}

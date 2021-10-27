using System;
using System.Collections.Generic;
using System.Text;
using WindowsFormsApp2.Model;
using System.Data.Entity;
using Npgsql;

namespace WindowsFormsApp2.Database
{
    class MyDbContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }

        private const string ConnectionString = "Server=localhost;User ID=postgres;Password=postgres;Database=kakeibo;port=5432";

        public MyDbContext() : base(new NpgsqlConnection(ConnectionString), true) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("public");
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkExample
{
    public class ShopDbContext:DbContext
    {
        private readonly string _conntectionString;

        public ShopDbContext()
        {
            //_conntectionString= "Server=SHAHADATPC\\\\SQLEXPRESS;Database=xxxx;User Id=xxx;Password=123456;Trust Server Certificate=True";
            _conntectionString = "Server=SHAHADATPC\\SQLEXPRESS;Database=CSharpB17;User Id=Shahadat16;Password=123456;Trust Server Certificate=True";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_conntectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>().ToTable("Reviews");
            modelBuilder.Entity<PurchaseOrder>().ToTable("PurchaseOrders");
            modelBuilder.Entity<PurchaseOrder>().HasKey(x => new { x.ProductId,x.CustomerId});
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set;}
        public DbSet<Customer> Customers { get; set;}
    }
}

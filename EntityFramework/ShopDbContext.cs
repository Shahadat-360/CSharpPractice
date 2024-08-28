using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework
{
    public class ShopDbContext:DbContext
    {
        private readonly string _connectionString; 
        public ShopDbContext()
        {
            //_connectionString = "Server=SHAHADATPC\\SQLEXPRESS;Database=CSharpB17;User Id=CSharpB17;Password=123456;Trust Server Certificate=True";
            _connectionString = "Server=SHAHADAT-PC\\SQLEXPRESS;Database=C785;User Id=simple;Password=123456;Trust Server Certificate=True";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Review>().ToTable("Reviews");
            modelBuilder.Entity<PurchaseOrder>().ToTable("PurchaseOrders");
            modelBuilder.Entity<PurchaseOrder>().HasKey(x =>new { x.ProductId,x.CustomerId });
            modelBuilder.Entity<Product>()
                .HasMany(x => x.Reviews)
                .WithOne(x => x.Product)
                .HasForeignKey(x => x.ProductId);
            modelBuilder.Entity<PurchaseOrder>()
                .HasOne(x => x.Product)
                .WithMany(x=>x.PurchaseOrders)
                .HasForeignKey(x => x.ProductId);
            modelBuilder.Entity<PurchaseOrder>()
                .HasOne(x => x.Customer)
                .WithMany(x => x.PurchaseOrders)
                .HasForeignKey(x => x.CustomerId);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Product> Products { get; set;}
        public DbSet<Customer> Customers { get; set;}
    }
}

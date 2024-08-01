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
            _connectionString = "Server=SHAHADATPC\\SQLEXPRESS;Database=CSharpB17;User Id=CSharpB17;Password=123456;Trust Server Certificate=True";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if(!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(_connectionString);
            }
        }
        
        public DbSet<Product> Products { get; set;}
    }
}

using Microsoft.EntityFrameworkCore;
using project1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project1.Data
{
    public class FashionShopDbContext : DbContext
    {

        public FashionShopDbContext(DbContextOptions<FashionShopDbContext> options
            ) : base(options) { 
        
        }
     
        public DbSet<User> User{ get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<CartProduct> CartProduct { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasIndex(p => new { p.Email })
                .IsUnique(true);
           
        }
    }
}

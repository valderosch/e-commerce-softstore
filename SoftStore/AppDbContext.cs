using Microsoft.EntityFrameworkCore;
using SoftStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SoftStore
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        } 

        public DbSet<Product> product { get; set; }
        public DbSet<Category> categoty { get; set; }
        public DbSet<CartItem> cartItem { get; set; }
        public DbSet<Order> order { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }

    }
}

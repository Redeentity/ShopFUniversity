using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data.Models;

namespace WebApplication2.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {
        
        }
        public DbSet<Item> Item { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<ShopCartItem> ShopCartItem { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
    }
}

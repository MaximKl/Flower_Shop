using Microsoft.EntityFrameworkCore;
using Shopp.Data.Models;

namespace Shopp.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) :
       base(options)
        { }
        public DbSet<Flower> Flower { get; set; }
        //функція для отримання та запису всіх категорій
        public DbSet<Category> Category { get; set; }

        public DbSet<ShopCartItem> ShopCartItem { get; set; }

        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<User> User { get; set; }


    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopp.Data.Models
{
    public class ShopCart
    {

        //змінна для роботи з класом налаштувань БД AppDBContext.cs
        private readonly AppDBContent appDBContent;

        public ShopCart(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public string ShopCartId { get; set; }


        public List<ShopCartItem> listShopItems { get; set; }


        public void DeleteFromCart(ShopCartItem item) {
            appDBContent.ShopCartItem.Remove(item);
            appDBContent.SaveChanges();
        }

        public static ShopCart GetCart(IServiceProvider services)
        {
            //створюємо об'єкт для роботи з сессією
            ISession session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            var context = services.GetService<AppDBContent>();

            //перевіряємо чи був створений кошик чи створюємо новий
            string shopCartId = session.GetString("CartId") ?? Guid.NewGuid().ToString(); //id кошикa
                                      //присваюємо id кошика сессії

            session.SetString("CartId", shopCartId);
            return new ShopCart(context) { ShopCartId = shopCartId };
        }

        //функція додавання товару до кошика
        public void AddToCart(Flower fl)
        {
            appDBContent.ShopCartItem.Add(new ShopCartItem
            {
                ShopCartId = ShopCartId,
                flower = fl,
                price = fl.price
            });
            appDBContent.SaveChanges();
        }
        //функція відображення товарів в кошику
        public List<ShopCartItem> getShopItems()
        {
            return appDBContent.ShopCartItem.Where(f => f.ShopCartId == ShopCartId).Include(s => s.flower).ToList();
        }



    }
}

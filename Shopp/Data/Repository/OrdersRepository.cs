using Shopp.Data.Interfaces;
using Shopp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopp.Data.Repository
{
    public class OrdersRepository: IAllOrders
    {
        private readonly AppDBContent appDBContent;
        private readonly ShopCart shopCart;
        public OrdersRepository(AppDBContent appDBContent, ShopCart
       shopCart)
        {
            this.appDBContent = appDBContent;
            this.shopCart = shopCart;
        }

        public void createOrder(Order order)
        {
            order.orderTime = DateTime.Now;
            appDBContent.Order.Add(order);
            appDBContent.SaveChanges();
            List<ShopCartItem> items = shopCart.listShopItems;
            foreach (ShopCartItem el in items)
            {
                var orderDetail = new OrderDetail()
                {
                    flowerID = el.flower.id,
                    orderID = order.id,
                    price = el.flower.price
                };
                appDBContent.OrderDetail.Add(orderDetail);
                shopCart.DeleteFromCart(el);

            }
        appDBContent.SaveChanges();
        }


    }
}

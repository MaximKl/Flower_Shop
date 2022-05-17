using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Shopp.Data.Interfaces;
using Shopp.Data.Models;
using System;

namespace Shopp.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allOrders;
        private readonly ShopCart shopCart;
        public OrderController(IAllOrders allOrders, ShopCart shopCart)
        {
            this.allOrders = allOrders;
            this.shopCart = shopCart;
        }
        //функція повертає View з діями користувача
        public IActionResult Checkout(User user)
        {
            shopCart.listShopItems = shopCart.getShopItems();
            if (Shopp.Data.Models.User.getRMail() != null && shopCart.listShopItems.Count != 0)
            {
                Order o = new Order
                {
                    name = user.name,
                    surname = user.surname,
                    phone = user.phone,
                    address = user.address,
                    email = user.email
                };
                allOrders.createOrder(o);
                return RedirectToAction("Complete");
            }
            return View();
        }


        public IActionResult Empty()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            shopCart.listShopItems = shopCart.getShopItems();
            if (shopCart.listShopItems.Count == 0)
            {
                ModelState.AddModelError("", "Ви повинні додати товар!");
                return RedirectToAction("Empty");
            }
            if (ModelState.IsValid)
            {
                allOrders.createOrder(order);
                return RedirectToAction("Complete");
            }
            return View(order);
        }
        public IActionResult Complete()
        {
            ViewBag.Title = "Завершено";
            return View();
        }




    }
}

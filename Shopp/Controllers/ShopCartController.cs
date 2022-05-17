using Microsoft.AspNetCore.Mvc;
using Shopp.Data.Interfaces;
using Shopp.Data.Models;
using Shopp.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Shopp.Controllers
{
    public class ShopCartController : Controller
    {

        private readonly IAllFlowers _flowRep;
        private readonly ShopCart _shopCart;
        public ShopCartController(IAllFlowers flowRep, ShopCart shopCart)
        {
            _flowRep = flowRep;
            _shopCart = shopCart;
        }

        public RedirectToActionResult DeleteFromBucket(int id) {

            List<ShopCartItem> shopList = _shopCart.getShopItems();
            _shopCart.listShopItems = shopList;
            for (int i=0;i<shopList.Count;i++) {

                if (shopList[i].id == id) {
                    _shopCart.DeleteFromCart(shopList[i]);
                }

            }
            return RedirectToAction("Bucket");
        }

        public ViewResult Bucket()
        {
            ViewBag.Title = "Кошик";
            List<ShopCartItem> shopList = _shopCart.getShopItems();
            _shopCart.listShopItems = shopList;
            ShopCartViewModel scvm = new ShopCartViewModel
            {
                shopCart = _shopCart
            };
            return View("Bucket",scvm);
        }

        public RedirectToActionResult AddToCart(int id)
        {
            var item = _flowRep.flowers.FirstOrDefault(i => i.id == id);
            if (item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Bucket");
        }
    }
}

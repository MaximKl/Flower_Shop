using Microsoft.AspNetCore.Mvc;
using Shopp.Data.Interfaces;
using Shopp.Data.Models;
using Shopp.ViewModels;
using System.Collections.Generic;
using System.Linq;

namespace Shopp.Controllers
{
    public class FlowersController : Controller
    {

        private readonly IAllFlowers _allFlowers;
        private readonly IFlowerCategory _allCatagories;
        public FlowersController(IAllFlowers iAllFlowers, IFlowerCategory iFlowersCateory)
        {
            _allFlowers = iAllFlowers;
            _allCatagories = iFlowersCateory;
        }


        //функціяя що повретає html-сторінку
        [Route("Flowers/List")]
        [Route("Flowers/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Flower> flowers = null;
            string currCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                flowers = _allFlowers.flowers.OrderBy(i => i.id);
            }
            else
            {
                if (string.Equals("house", category,
               System.StringComparison.OrdinalIgnoreCase))
                {
                    flowers = _allFlowers.flowers.Where(i =>i.Category.categoryName.Equals("Домашні рослини")).OrderBy(i => i.id);
                    currCategory = "Домашні рослини";
                }
                else if (string.Equals("garden", category,
               System.StringComparison.OrdinalIgnoreCase))
                {
                    flowers = _allFlowers.flowers.Where(i =>i.Category.categoryName.Equals("Садові рослини")).OrderBy(i => i.id);
                    currCategory = "Садові рослини";
                }
            }
            currCategory = _category;
            FlowersListViewModels flowObj = new FlowersListViewModels
            {
                allFlowers = flowers,
                currCategory = currCategory
            };
            ViewBag.Title = "Сторінка з рослинами";
            return View(flowObj);//передача об'єкта в шаблон
        }
    }
}

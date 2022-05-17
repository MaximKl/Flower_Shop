using Microsoft.AspNetCore.Mvc;
using Shopp.Data.Interfaces;
using Shopp.Data.Models;
using Shopp.ViewModels;

namespace Shopp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllFlowers _flowRep;
        public HomeController(IAllFlowers flowrep)
        {
            _flowRep = flowrep;
        }
        [Route("")]
        [Route("Home/MyHome")]
        public ViewResult MyHome()
        {
            ViewBag.Title = "Домашня сторінка";
            HomeViewModel homeFlow = new HomeViewModel
            {
                favFlower = _flowRep.getFavFlower
            };
            return View(homeFlow);
        }

    }
}

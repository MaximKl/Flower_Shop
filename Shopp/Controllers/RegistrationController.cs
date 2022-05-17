using Microsoft.AspNetCore.Mvc;
using Shopp.Data.Interfaces;
using Shopp.Data.Models;
using System.ComponentModel.DataAnnotations;

namespace Shopp.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly IAllUsers iau;
        public static int isEqual = 0;
        public RegistrationController(IAllUsers iau)
        {
            this.iau = iau;
        }

        public ViewResult Sign() {
            ViewBag.Title = "Вхід";
            return View("Sign");
        }

        [HttpPost]
        public IActionResult Sign(User user) {

            User u = iau.getUser(user);
            if (u != null) {
                Shopp.Data.Models.User.setReadyMail(user.email);
                return View("Info");
            }
            isEqual = 2;
            return View("Empty");
        }


        public new ViewResult User()
        {
            ViewBag.Title = "Реєстрація";
            return View("User");
        }

        public IActionResult Exit() {
            Shopp.Data.Models.User.setReadyMail(null);
            return View("User");
        }


        public ViewResult Info()
        {
            if (Shopp.Data.Models.User.getRMail() == null) {
                return View("User");
            }
            ViewBag.Title = "Профіль";
            return View("Info");
        }

        [HttpPost]
        public new IActionResult User(User user, string password2)
        {
            if (user.email != null && user.surname != null && user.phone != null && user.address != null && user.name != null && user.password!=null)
            {
                if (user.password.Equals(password2) &&user.password.Length>=4)
                {
                    if (iau.createUser(user) == true)
                    {
                        Shopp.Data.Models.User.setReadyMail(user.email);
                        return View("Complete");
                    }                   
                    return View("Empty");
                }
                isEqual = 1;
                return View("Empty");
            }
            return View(user);
        }




    }
}

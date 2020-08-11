using LayeredArchitectureExample.BLL.Abstract;
using LayeredArchitectureExample.BLL.Concrete;
using LayeredArchitectureExample.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LayeredArchitectureExample.Controllers
{
    public class HomeController : Controller
    {
        private IUserManager _userManager;
        public IUserManager UserManager
        {
            get
            {
                _userManager = _userManager ?? new UserManager();
                return _userManager;
            }
            private set
            {
                _userManager = value;
            }
        }
        public ActionResult Index()
        {
            try
            {
                UserManager.Add(new User() { Id = "270ff9af-ce3e-4d72-9aa8-cfb32a75bc2d", Name = "Merve", SurName = "Bayrak", FullName = "MerveBayrak" });
                var liste = UserManager.GetList();
            }
            catch (Exception ex)
            {
                
            }
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
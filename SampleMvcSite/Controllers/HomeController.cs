using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleMvcSite.Models;

namespace SampleMvcSite.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        public ActionResult Home()
        {
            //Index is the first page that will load when you go to the webpage

            HomeModel model = new HomeModel();
            model.someRandomString = "I'm a C# string all up in your HTML!";

            return View(model);
        }

        public ActionResult Index()
        {


            return RedirectToAction("Home");
        }
    }
}

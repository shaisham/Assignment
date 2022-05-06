using HOLDay3.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HOLDay3.Controllers
{
    public class HomeController : Controller
    {
        //1.  Using ViewBag & ViewData to pass data between controller & view :
        public ActionResult Index2()
        {
            ViewData["str1"] = "This is a string passed using ViewData";
            ViewData["num1"] = 100;

            ViewBag.str2 = "This is a string passed using ViewBag";
            ViewBag.num2 = 200;
            return View();

        //https://localhost:44357/Home/index2

        }

        //2. Passing data between view & controller

        public ActionResult AddUser()
        {
            return View();
        }

        public ActionResult SaveUser(User u)
        {
           StreamWriter sw = new  StreamWriter (Server.MapPath("~/App_Data/users.txt"), true);
            sw.WriteLine("User details added on: " + DateTime.Now.ToString());
            sw.WriteLine("User name: " + u.UserName);
            sw.WriteLine("Password: " + u.Password);
            sw.WriteLine();
            sw.Close();
            return Content("User details have been saved");

            //https://localhost:44357/Home/AddUser
        }

        // 3. Using HTML Helpers (weakly-typed & strongly-typed)

        public ActionResult HtmlHelpers()
        {
            return View();
        }


    }
}

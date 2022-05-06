using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

//Project Day 2 
namespace ProjectDay2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //1. Creating a contentResult 
        public ContentResult Index(string id)
        {
            if (id == null)
            {
                return Content("<h1>This is a demo of  ContentResult </ h1 > ");
            }
            else if (id.ToLower() == "plain")
            {
                return Content("<h1>My name is shameer </ h1 > ", "text / plain");
            }
            else if (id.ToLower() == "html")
            {
                return Content("<h1>I'm from Hyderabad </ h1 > ", "text / html");
            }
            else if (id.ToLower() == "xml")
            {
                return Content("<h1>Good Bye </ h1 > ", "text / xml");
            }
            return Content("Invalid content type");
        }

        //2. creating a  FileResult 

        public ActionResult DownloadFile()
        {
            if (!System.IO.File.Exists(@"D:\lighthouse.jpg"))
            {
                return Content("File to be downloaded not found");
            }
            return File(@"D:\lighthouse.jpg", "image/jpg", "default.jpg");
        }


        // 3. ReDirectResult
        public ActionResult Google()
        {
            return Redirect("http://www.google.com");
        }


        // 4. – RedirectToActionResult

        public ActionResult StartPage()
        {
            return RedirectToAction("Index", new { id = "xml" });
        }

        // 5. Creating Views:

        public ViewResult Login()
        {
            return View();
        }
        public ViewResult AboutUs()
        {
            return View();
        }

        // 6. created a partial view called Menuwidget and used it in Login.cshtml and AboutUscshtml files. 


        // 7.Creating and Using Model's

    }
}
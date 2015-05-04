using Sozialheap.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Sozialheap.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            //ViewBag.Message = "Your application description page.";

            var UserName1 = HttpContext.User.Identity.Name;

            ApplicationDbContext db = new ApplicationDbContext();

           var test = from s in db.Users
                        select s;
           StringBuilder sb = new StringBuilder();

            foreach(var item in test)
            {
                sb.Append(item.UserName + ", ");
            }

            ViewBag.Message = sb.ToString();

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
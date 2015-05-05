using Sozialheap.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sozialheap.Controllers
{
    public class UserController : Controller
    {
        SozialService service = new SozialService();

        public ActionResult Feed()
        {
            // TODO: create the view!!

            return View();
        }

        public ActionResult UserFeed()
        {
            return View();
        }
    }
}
using Sozialheap.Models;
using Sozialheap.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sozialheap.Controllers
{
    public class QuestionController : Controller
    {
        SozialService service = new SozialService();
        public ActionResult CreateQuestion()
        {
            ViewBag.Message = "Just testing :)";

            return View();
        }
    }
}
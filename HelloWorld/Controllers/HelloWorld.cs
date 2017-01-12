using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld.Controllers
{
    public class HelloWorld : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            return View();
        }
    }
}
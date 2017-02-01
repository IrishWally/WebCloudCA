using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebCloudCA.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

       

        //Controller for the Reviews Page
        public ActionResult Reviews()
        {
            return View();
        }
    }
}
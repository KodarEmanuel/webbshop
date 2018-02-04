using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Webshop.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Index
        public ActionResult Home()
        {
            return View();
        }
    }
}
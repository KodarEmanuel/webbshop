using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Webshop.Controllers
{
    public class ProductsController : Controller
    {
        public ActionResult Category()
        {
            return View("~/Views/Products/Category.cshtml");
        }
       

    }
}



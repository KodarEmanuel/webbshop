using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Webshop.Models;

namespace Webshop.Controllers
{
    
    public class ProductsController : Controller
    {

        public ActionResult Category()
        {
            new ProdList();
            return View();
        }

        public ActionResult AddToCart(int Amount)
        {
            return View();
        }
    }
}



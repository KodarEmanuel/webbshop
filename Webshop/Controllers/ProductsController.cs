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
            ProdList prodList = new ProdList();

            for (int i = 0; i < 50; i++)
            {
                prodList.product.Add(new Product
                {
                    Id = i,
                    CatagoryId = 1,
                    Name = "Name",
                    Description = "Des",
                    Price = 499,
                    PicturePath = "../../Content/img/Cat1/Nike2.jpg"

                });
            }
            if (prodList.product.Count() == 0 )
            {
                return View();
            }
            return View(prodList);
        }

        public ActionResult AddToCart(int Amount, int ProdId)
        {

            return null;
      
        }
    }
}



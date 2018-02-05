using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webshop.Models
{    
    public class ProdList
    {
        List<Product> product = new List<Product>();
        public ProdList()
        {
            for (int i = 0; i < 50; i++)
            {
                product.Add(new Product
                {
                    Id = i,
                    CatagoryId = 1,
                    Name = "Name",
                    Description = "Des",
                    Price = 499,
                    PicturePath = "../../Content/img/Cat1/Nike2.jpg"
                    
                });
            }

        }
        public int Getcount()
        {            
            return product.Count;            
        }

        public int GetId(int x)
        {
            return product[x].Id;
        }

        public int GetCatagoryId(int x)
        {
            return product[x].CatagoryId;
        }

        public string ReturnName(int x)
        {
            return product[x].Name;
        }

        public string ReturnDescription(int x)
        {
            return product[x].Description;
        }

        public string ReturnImgPath(int x)
        {
            return product[x].PicturePath;
        }

    }   
}
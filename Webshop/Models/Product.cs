using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Webshop.Models
{
    public class Product
    {
      public int Id;
      public string Name;
      public string Description;
      public int Price;
      public string[] PicturePaths;
    }
}
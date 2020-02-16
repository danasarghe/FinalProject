using ModelsClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class ProductView
    {
     
        public int Productid { get; set; }

        public Genre Genre { get; set; }

        public Brand Brand { get; set; }

        public string Title { get; set; }
  
        public decimal Price { get; set; }
 
        public int Size { get; set; }
        
    }
}
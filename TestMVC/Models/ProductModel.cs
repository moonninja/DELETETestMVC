using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestMVC.Models
{
    public class ProductModel
    {
        public Guid ID{ get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
    }
}
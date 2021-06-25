using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVC.Models;

namespace TestMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<ProductModel> list = new List<ProductModel>();
            for (int i = 0; i < 3; i++)
            {
                ProductModel product = new ProductModel()
                {
                    ID = Guid.NewGuid(),
                    Name = "Name" + i.ToString(),
                    Description = "Description" + i.ToString(),
                    Price = "Price" + i.ToString()
                };
                list.Add(product);
            }
            return View(list);
        }
        [HttpPost]
        public ActionResult AddToCart(FormCollection form)
        {
            var ids = form["item.ID"];
            var strids = ids.Split(',');
            Guid guid = Guid.Parse(strids[0]);
            return View("Index");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
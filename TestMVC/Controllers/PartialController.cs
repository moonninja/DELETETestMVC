﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVC.Models;


namespace TestMVC.Controllers
{
    public class PartialController : Controller
    {
        // GET: Partial
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
        public ActionResult AddToCart(ProductModel model)
        {
            return RedirectToAction("Index");
        }
        [ChildActionOnly]
        public ActionResult RenderMenu(ProductModel model)
        {
            return PartialView("_Partial", model);
        }

    }
}
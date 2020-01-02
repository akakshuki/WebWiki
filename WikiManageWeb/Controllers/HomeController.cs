﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WikiManageWeb.Dao;
using WikiManageWeb.Models.ModelsView;


namespace WikiManageWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var list = new ProductDao().GetListProductClientView();
            return View(list);
        }

        public ActionResult CreatNenContent()
        {
            return View();
        }

        public ActionResult InforUser(int id)
        {

            return View();
        }

        [HttpGet]
        public ActionResult ListProductByCategory(int id)
        {
            var list = new ProductDao().GetListProductClientView(id);
            return View(list);
        }


        public ActionResult ContentProduct(int id)
        {
            var detailProduct = new ProductDao().ContenProduct(id);
            return View(detailProduct);

        }

        [HttpPost]
        public ActionResult LetUserComment(EditProductMv editProduct)
        {
            
            var result = new ProductDao().LetUserComment(editProduct);
            return RedirectToAction("ContentProduct","Home", editProduct.ProductId);
        }
    }
}
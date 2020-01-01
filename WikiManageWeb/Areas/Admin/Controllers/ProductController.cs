using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WikiManageWeb.Common;
using WikiManageWeb.Dao;
using WikiManageWeb.Models.ModelsView;

namespace WikiManageWeb.Areas.Admin.Controllers
{
    public class ProductController : BaseController
    {
        // GET: Admin/Product
        public ActionResult Index()
        {
            var result = new ProductDao().GetAlListProducts();
            return View(result);
        }

        // GET: Admin/Product/Details/5
        public ActionResult Details(int id)
        {
            var producDetail = new ProductDao().GetDetailProduct(id);
            return View(producDetail);
        }

        // GET: Admin/Product/Create
        public ActionResult Create()
        {
            ViewBag.ListCategory = new CategoryDao().ListCate();

            return View();
        }

        // POST: Admin/Product/Create
        [HttpPost]
        public ActionResult Create(ProductMv product)
        {
            ViewBag.ListCategory = new CategoryDao().ListCate();
            if (ModelState.IsValid)
            {
                try
                {
                    if (!new ProductDao().ChecKTileExist(product.Title))
                    {
                        var data = (UserLogin)Session[CommonConstants.USER_SESSION];
                        product.UserId = data.UserID;
                        if (new ProductDao().CreateNewProduct(product))
                        {
                            TempData["SuccessMes"] = "Thêm mới thành công";
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            ViewBag.Message = "Hệ thống gặp sự cố, hãy thử lại lần nữa";
                            return View();
                        }

                    }
                    else
                    {
                        ViewBag.Message = "Tiêu đề này đã có sẵn từ trước vui lòng kiểm tra lại";
                        return View();
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    ViewBag.Message = "Hệ thống gặp sự cố, hãy thử lại lần nữa";
                    return View();
                }

            }
            else
            {
                return View();
            }
        }

        // GET: Admin/Product/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.ListCategory = new CategoryDao().ListCate();
            var data = new ProductDao().GetDetailProduct(id);
            return View(data);
        }

        // POST: Admin/Product/Edit/5
        [HttpPost]
        public ActionResult Edit(ProductMv product)
        {
            ViewBag.ListCategory = new CategoryDao().ListCate();
            var doto = new ProductDao().GetDetailProduct(product.ID);
            if (ModelState.IsValid)
            {
                try
                {

                    if (new ProductDao().EditProduct(product))
                    {
                        TempData["SuccessMes"] = "Sửa thành công";
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        ViewBag.Message = "Hệ thống gặp sự cố, hãy thử lại lần nữa";
                        return View(doto);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    ViewBag.Message = "Hệ thống gặp sự cố, hãy thử lại lần nữa";
                    return View(doto);
                }

            }
            else
            {
                return View(doto);
            }
        }

        // GET: Admin/Product/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {

                if (new ProductDao().DeleteProduct(id))
                {
                    TempData["SuccessMes"] = "Xóa bài viết thành công";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "Bài đang có comment không xóa được";
                    return View("Index");
                }


            }
            catch
            {
                TempData["Message"] = "Hệ thống gặp sự cố, hãy thử lại lần nữa";
                return View("Index");
            }
        }
    }



}

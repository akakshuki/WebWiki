using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WikiManageWeb.Common;
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
            ViewBag.ListCategory = new CategoryDao().ListCate();
            return View();
        }
        [HttpPost]
        public ActionResult CreatNenContent(ProductMv product)
        {
            var data = (UserLogin)Session[CommonConstants.USER_SESSION];

            if (data != null)
            {
               
                ViewBag.ListCategory = new CategoryDao().ListCate();
                if (ModelState.IsValid)
                {
                    try
                    {
                        if (!new ProductDao().ChecKTileExist(product.Title))
                        {

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
            else
            {
                return RedirectToAction("Login", "Account");
            }
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
            var userSession = (UserLogin)Session[CommonConstants.USER_SESSION];
            ViewBag.InfoSession = userSession;
            return View(detailProduct);

        }

        [HttpPost]
        public ActionResult LetUserComment(EditProductMv editProduct)
        {
            var id = editProduct.ProductId;
            var userSession = (UserLogin)Session[CommonConstants.USER_SESSION];

            if (userSession != null)
            {
                editProduct.UserID = userSession.UserID;
                if (new ProductDao().LetUserComment(editProduct))
                {
                    return RedirectToAction("ContentProduct", "Home", new { id = id });
                }
                else
                {
                    TempData[CommonConstants.Message] = "khoong thanh cong";
                    return RedirectToAction("ContentProduct", "Home", new { id = id });
                }
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }


        }
        [HttpPost]
        public ActionResult DeleteComment(EditProductMv edit)
        {
            var id = edit.ProductId;
            if (new ProductDao().DeleteComment(edit.ID))
            {
                return RedirectToAction("ContentProduct", "Home", new { id = id });
            }
            else
            {
                return RedirectToAction("ContentProduct", "Home", new { id = id });
            }

        }
        [HttpPost]
        public JsonResult Delete(int id)
        {
            try
            {

                if (new ProductDao().DeleteProduct(id))
                {
                  
                    return Json(new
                    {
                        status = true
                    });
                }
                else
                {
                    return Json(new
                    {
                        status = false
                    });
                }


            }
            catch
            {

                return Json(new
                {
                    status = false
                });
            }
        }

    }
}

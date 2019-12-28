using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WikiManageWeb.Dao;
using WikiManageWeb.Models.ModelsView;

namespace WikiManageWeb.Areas.Admin.Controllers
{
    public class CategoryController : BaseController
    {
        // GET: Admin/Category
        public ActionResult Index()
        {
            var categoryList = new CategoryDao().ListCate();
            return View(categoryList);
        }

        // GET: Admin/Category/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Category/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Category/Create
        [HttpPost]
        public ActionResult Create(CategoryMv category)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (!new CategoryDao().checkExistCategory(category.Name))
                    {
                        if (new CategoryDao().CreateNewCategory(category))
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
                        ViewBag.Message = "Danh Mục này đã có sẵn từ trước vui lòng kiểm tra lại";
                        return View();
                    }

                }
                catch
                {
                    ViewBag.Message = "Hệ thống gặp sự cố, hãy thử lại lần nữa";
                    return View();
                }

            }
            else
            {

                
                return View();
            }
        }

        // GET: Admin/Category/Edit/5
            public ActionResult Edit(int id)
            {
                 var data = new CategoryDao().getCategoryDetail(id);  
                return View(data);
            }

        // POST: Admin/Category/Edit/5
        [HttpPost]
        public ActionResult Edit(CategoryMv category)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (! new CategoryDao().checkExistCategory(category.Name))
                    {
                        if (new CategoryDao().EditCategory(category))
                        {
                            TempData["SuccessMes"] = "Sửa danh mục thành công";
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            ViewBag.Message = "Hệ thống gặp sự cố  không thể thêm được thử lại";
                            return View();
                        }
                    }
                    else
                    {
                        ViewBag.Message = "Danh Mục này đã có sẵn từ trước vui lòng kiểm tra lại";
                        return View();
                    }


                   
                }
                catch
                {
                    ViewBag.Message = "Hệ thống gặp sự cố, hãy thử lại lần nữa";
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
     
        public ActionResult Delete(int id)
        {
            try
            {

                if (new CategoryDao().DeleteCategory(id))
                {
                    TempData["SuccessMes"] = "Xóa danh mục thành công";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["Message"] = "Danh mục đang có bài viết không xóa được";
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

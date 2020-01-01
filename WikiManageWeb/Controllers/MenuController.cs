using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WikiManageWeb.Dao;

namespace WikiManageWeb.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Index()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult HeaderBar()
        {
            return PartialView();
        }
        [ChildActionOnly]
        public ActionResult NavigationBar()
        {
            var listCategory = new CategoryDao().ListCateClient();
            return PartialView(listCategory);
        }
    }
}
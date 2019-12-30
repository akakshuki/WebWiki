using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            return PartialView();
        }
    }
}
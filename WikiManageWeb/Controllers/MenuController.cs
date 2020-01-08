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
            var userSession = (UserLogin)Session[CommonConstants.USER_SESSION];
            UserMv userinf = null;
            if (userSession != null)
            {
              userinf = new UserMv()
                {
                    ID = userSession.UserID,
                    UserName = userSession.UserName

                };
                return PartialView(userinf);
            }
            else
            {
                 userinf = null;
                 return PartialView(userinf);
            }
            
        }
        [ChildActionOnly]
        public ActionResult NavigationBar()
        {

            var listCategory = new CategoryDao().ListCateClient();
            return PartialView(listCategory);
        }

        public JsonResult SearchProduct(string name)
        {
            var data = new ProductDao().SearchProduct(name);
            return Json(new
            {
                data = data,
                GCNotificationStatus = true
            }, JsonRequestBehavior.AllowGet);
        }
    }
}
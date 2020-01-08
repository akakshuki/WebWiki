using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WikiManageWeb.Dao;

namespace WikiManageWeb.Areas.Admin.Controllers
{
    public class AccountUserController : BaseController
    {
        // GET: Admin/AccountUser
        public ActionResult Index() {
            var list = new UserDao().ListUserAccount();
            return View(list);
        }

        public JsonResult BlockUser(int id)
        {
            return null;
        }
    }
}
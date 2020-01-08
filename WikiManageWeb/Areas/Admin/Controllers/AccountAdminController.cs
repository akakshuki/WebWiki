using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WikiManageWeb.Dao;

namespace WikiManageWeb.Areas.Admin.Controllers
{
    public class AccountAdminController : BaseController
    {
        // GET: Admin/AccountAdmin
        public ActionResult Index()
        {
            var list = new UserDao().ListAdminAccount();
            return View(list);
        }
    }
}
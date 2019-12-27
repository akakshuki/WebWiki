using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WikiManageWeb.Dao;

namespace WikiManageWeb.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string email, string password)
        {
            var result = new UserDao().LoginAdmin(email,password);
            if (result == 0)
            {
                ViewBag.Message = "Tài khoản hoặc mật khẩu không hợp lệ";
            }
            else if(result == -1)
            {
                ViewBag.Message = "Tài khoản đã bị khóa từ trước";
            }
            else
            {
                var checkRole = new UserDao().CheckRoleUserById(result);
                if (checkRole.idR==1)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return Redirect("~/");
                }
            }

            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
    }
}
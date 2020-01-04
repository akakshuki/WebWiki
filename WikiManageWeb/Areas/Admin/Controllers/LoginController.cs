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
            var result = new UserDao().LoginAdmin(email, password);
            if (result == 0)
            {
                ViewBag.Message = "Tài khoản hoặc mật khẩu không hợp lệ";
            }
            else if (result == -1)
            {
                ViewBag.Message = "Tài khoản đã bị khóa từ trước";
            }
            else
            {
                var checkRole = new UserDao().CheckRoleUserById(result);
                if (checkRole.idR == 1)
                {
                    Session[CommonConstants.USER_SESSION] = null;
                    var userSession = new UserLogin();
                    userSession.UserID = checkRole.ID;
                    userSession.UserName = checkRole.UserName;
                    userSession.IdR = checkRole.idR;
                    Session.Add(CommonConstants.USER_SESSION, userSession);
                    return RedirectToAction("AdminHome", "Home");
                }
                else
                {
                    Session[CommonConstants.USER_SESSION] = null;
                    var userSession = new UserLogin();
                    userSession.UserID = checkRole.ID;
                    userSession.UserName = checkRole.UserName;
                    userSession.IdR = checkRole.idR;
                    Session.Add(CommonConstants.USER_SESSION, userSession);
                    return  Redirect("/Home");

                }
            }

            return View();
        }

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(UserMv user)
        {
            
            if (! new UserDao().CheckEmailUser(user.Email))
            {
                var result = new UserDao().RegisterAdminAccount(user);
                if (result)
                {
                  return  RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.Message = "Đăng kí không thành công";
                }
            }
            else
            {
                ViewBag.Message = "Tài khoản đã có ai đó sử dụng";
            }
            return View();
        }

        public ActionResult AdminLogOut()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
        [ChildActionOnly]
        public ActionResult MenuHeader(string parameter1)
        {
            var userSession = (UserLogin)Session[CommonConstants.USER_SESSION];
            var userinf = new UserMv();
            userinf.ID = userSession.UserID;
            userinf.UserName = userSession.UserName;
            return PartialView(userinf);
        }
    }
}
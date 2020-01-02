using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WikiManageWeb.Common;
using WikiManageWeb.Dao;
using WikiManageWeb.Models.ModelsView;

namespace WikiManageWeb.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string Email, string Password)
        {
            if (ModelState.IsValid)
            {
                var result = new UserDao().LoginClient(new UserMv()
                {
                    Email = Email,
                    Password = Password
                });
                if (result == 0)
                {
                    ViewBag.Message = "Tài khoản hoặc mật khẩu không hợp lệ";
                    return View();
                }
                else if (result == -1)
                {
                    ViewBag.Message = "Tài khoản đã bị khóa từ trước";
                      return View();
                }
                else
                {
                    var checkRole = new UserDao().CheckRoleUserById(result);

                    var userSession = new UserLogin();
                    userSession.UserID = checkRole.ID;
                    userSession.UserName = checkRole.UserName;
                    userSession.IdR = checkRole.idR;
                    Session.Add(CommonConstants.USER_SESSION, userSession);
                    return RedirectToAction("Index", "Home");

                }

            }
            else
            {
                return View();
            }

        }

        public ActionResult Register()
        {

            return View();
        }
        [HttpPost]
        public ActionResult Register(UserMv user)
        {

            if (ModelState.IsValid)
            {
                if (!new UserDao().CheckEmailUser(user.Email))
                {

                    if (new UserDao().RegisterClientAccount(user))
                    {
                        return RedirectToAction("Login", "Account");
                    }
                    else
                    {

                        ViewBag.Message = "Đăng kí không thành công";
                        return View();
                    }
                }
                else
                {
                    ViewBag.Message = "Tài khoản đã có ai đó sử dụng";
                    return View();
                }
            }
            else
            {
                return View();
            }
        }

        public ActionResult LogOut()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Home");
        }
    }
}
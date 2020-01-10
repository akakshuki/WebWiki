using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WikiManageWeb.Common;
using WikiManageWeb.Dao;
using WikiManageWeb.Models.AuthModelView;

namespace WikiManageWeb.Controllers
{
    public class DeveloperController : Controller
    {
        // GET: Developer
        public ActionResult Register()
        {
            ViewBag.ListRolePartner = new PartnerDao().GetListRolePartner();
            return View();
        }

        [HttpPost]
        public ActionResult Register(AccountService account)
        {
            ViewBag.ListRolePartner = new PartnerDao().GetListRolePartner();
            if (ModelState.IsValid)
            {
                var value = new PartnerDao().Create(account);
                return View();
            }
            else
            {
                return View();
            }
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(string Name, string Password )
        {

            if (ModelState.IsValid)
            {
                var account = new AccountService()
                {
                    Name = Name,
                    Password = Password,
                };
                var value = new PartnerDao().GetPartnerLogin(account);
                Session[CommonConstants.ACCOUNT_DEV] = value;
                return RedirectToAction("MainPage","Developer");
            }
            else
            {
                return View();
            }
        }
        public ActionResult MainPage()
        {
            AccountService account =(AccountService) Session[CommonConstants.ACCOUNT_DEV];
            if (account != null)
            {
                return View(account);
            }
            else
            {
                return RedirectToAction("Login");
            }
            
        }
    }
}
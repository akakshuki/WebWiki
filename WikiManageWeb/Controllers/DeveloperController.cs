using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WikiManageWeb.Controllers
{
    public class DeveloperController : Controller
    {
        // GET: Developer
        public ActionResult Register()
        {
            return View();
        }
    }
}
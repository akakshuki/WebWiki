using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebPartnerWIki.AuthSerive;
using WebPartnerWIki.Models;

namespace WebPartnerWIki.Controllers
{
    public class HomeController : Controller
    {
        public AuthSerive.KiemSoatPartner cl = null;

        public HomeController()
        {
            cl = new KiemSoatPartnerClient();
        }
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult SearchProduct(string name)
        {
            
            var data = cl.TimBaiVietTheoTen(name , CommonConst.Common_Token);
            return Json(new
            {
                data = data,
                GCNotificationStatus = true
            }, JsonRequestBehavior.AllowGet);
        }
        public ActionResult ContentProduct(int id)
        {
            var detailProduct =cl.NoiDungBaiVietClient(id, CommonConst.Common_Token);
         
            return View(detailProduct);

        }
    }
}
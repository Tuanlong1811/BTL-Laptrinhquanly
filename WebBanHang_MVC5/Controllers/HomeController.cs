using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ictshop.Controllers
{
    public class HomeController : Controller
    {
      
        public ActionResult Index()
        {
       
            return View();

        }

        public ActionResult About()
        {
            ViewBag.Message = "Trang mô tả ứng dụng ";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Trang liên hệ ";

            return View();
        }
        public ActionResult SlidePartial()
        {
            return PartialView();

        }
    }
}
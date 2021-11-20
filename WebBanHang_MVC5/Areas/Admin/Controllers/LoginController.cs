using Ictshop.Areas.Admin.Models;
using Ictshop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoginModel = Ictshop.Areas.Admin.Models.LoginModel;

namespace Ictshop.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        private QlBanHang db = new QlBanHang();

        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var res = db.Nguoidungs.SingleOrDefault(x => x.Email == model.UserName);
                if (res==null)
                {
                    ModelState.AddModelError("","Tài khoản không tồn tại");
                } 
                else
                {
                    if (res.Matkhau == model.PassWord && res.IDQuyen ==2)
                    {
                       return RedirectToAction("Index", "Home");
                    }    
                    else
                    {
                        ModelState.AddModelError("", "Mật khẩu không đúng");
                    }
                }
            }
            return View("Index");
        }

        public ActionResult Logout()
        {
            return View("Index");
        }
    }
}
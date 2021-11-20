using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ictshop.Models;
namespace Ictshop.Controllers
{
    public class UserController : Controller
    {
        QlBanHang db = new QlBanHang();
        // ĐĂNG KÝ
        public ActionResult Dangky()
        {
            return View();
        }

        // ĐĂNG KÝ PHƯƠNG THỨC POST
        [HttpPost]
        public ActionResult Dangky(Nguoidung nguoidung)
        {
            try
            {
                // Thêm người dùng  mới
                nguoidung.IDQuyen = 1;
                db.Nguoidungs.Add(nguoidung);
                // Lưu lại vào cơ sở dữ liệu
                db.SaveChanges();
                // Nếu dữ liệu đúng thì trả về trang đăng nhập
                if (ModelState.IsValid)
                {
                    return RedirectToAction("Dangnhap");
                }
                return View("Dangky");

            }
            catch
            {
                return View();
            }
        }

        public ActionResult Dangnhap()
        {
            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(FormCollection userForm)
        {
            if (ModelState.IsValid)
            {

                string user = userForm["TaiKhoan"].ToString();
                string password = userForm["MatKhau"].ToString();


                //var f_password = GetMD5(password);
                var data = db.Nguoidungs.Where(s => s.Email.Equals(user) && s.Matkhau.Equals(password)).ToList();
                if (data.Count() > 0)
                {
                    //add session
                    //Session["FullName"] = data.FirstOrDefault().FirstName + " " + data.FirstOrDefault().LastName;
                    //Session["Email"] = data.FirstOrDefault().Email;
                    //Session["idUser"] = data.FirstOrDefault().idUser;
                    var res = db.Nguoidungs.SingleOrDefault(s => s.Email.Equals(user));
                    {
                        if (res==null)
                        {
                            ModelState.AddModelError("", "Tài khoản không tồn tại");

                        }
                        else
                        {
                            if (res.Matkhau == password && res.IDQuyen==1)
                            {
                                return RedirectToAction("Index");

                            }
                        }                            
                    }
                }
                else
                {
                    ViewBag.error = "Login failed";
                    return RedirectToAction("Login");
                }
            }
            return View();

        }



        [HttpPost]
        public ActionResult Dangnhap(FormCollection userlog)
        {
            string userMail = userlog["userMail"].ToString();
            string password = userlog["password"].ToString();
            var islogin = db.Nguoidungs.SingleOrDefault(x => x.Email.Equals(userMail) && x.Matkhau.Equals(password));

            if (islogin != null)
            {
                if (userMail == islogin.Email && password == islogin.Matkhau && islogin.IDQuyen==1)
                {
                    Session["use"] = islogin;
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return RedirectToAction("Dangnhap");
                }
            }
            else
            {
                ViewBag.Fail = "Đăng nhập thất bại";
                return View("Dangnhap");
            }

        }
        public ActionResult DangXuat()
        {
            Session["use"] = null;
            return RedirectToAction("Index", "Home");

        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CHBQA.Models;

namespace CHBQA.Controllers.Area
{
    public class AdminController : Controller
    {
        // GET: Admin
        MyDataDataContext data = new MyDataDataContext();
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Login(FormCollection collection)
        {
            var userName = collection["taikhoan"];
            var passWord = collection["matkhau"];
            QTV admin = data.QTVs.SingleOrDefault(x => x.taikhoan == userName && x.matkhau == passWord);
            if (admin != null)   //Login thanh cong
            {
                ViewBag.ThongBao = "Dang nhap thanh cong!";
                Session["taikhoan"] = admin;

                return RedirectToAction("LoaimhAdmin", "LoaiMatHangAdmin");
            }
            else
            {
                ViewBag.ThongBao = "Dang nhap that bai!";
                return RedirectToAction("Login", "Admin");
            }
        }
        public ActionResult CheckHD(int id = -1)
        {
            
            var listhd = data.DDHs.ToList();
            if( id >= 0)
            {
                listhd = (from ddh in listhd where ddh.trang_thai == id select ddh).ToList() ;

            }
            return View(listhd);
        }

    }
}
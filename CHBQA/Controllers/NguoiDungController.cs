using CHBQA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CHBQA.Controllers
{
    public class NguoiDungController : Controller
    {
        // GET: NguoiDung
        MyDataDataContext data = new MyDataDataContext();
        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangKy(FormCollection collection, KhachHang kh)
        {
            //var id_kh = collection["id_kh"];
            var ten = collection["ten"];
            var taikhoan = collection["taikhoan"];
            var matkhau = collection["matkhau"];
            var MatKhauXacNhan = collection["MatKhauXacNhan"];
            var email = collection["email"];
            var diachi = collection["diachi"];
            var sdt = collection["sdt"];
            if (String.IsNullOrEmpty(MatKhauXacNhan))
            {
                ViewData["NhapMKXN"] = "Phải nhập mật khẩu xác nhận!";
            }
            else
            {
                if (!matkhau.Equals(MatKhauXacNhan))
                {
                    ViewData["MatKhauGiongNhau"] = "Mật khẩu và mật khẩu xác nhận phải giống nhau";
                }
                else
                {
                    //   kh.id_kh = id_kh;
                    kh.ten = ten;
                    kh.taikhoan = taikhoan;
                    kh.matkhau = matkhau;
                    kh.email = email;
                    kh.diachi = diachi;
                    kh.sdt = sdt;
                    data.KhachHangs.InsertOnSubmit(kh);
                    data.SubmitChanges();

                    return RedirectToAction("DangNhap");
                }
            }
            return this.DangKy();
        }

        [HttpGet]
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection collection)
        {
            var taikhoan = collection["taikhoan"];
            var matkhau = collection["matkhau"];
            KhachHang kh = data.KhachHangs.SingleOrDefault(n => n.taikhoan == taikhoan && n.matkhau == matkhau);
            if (kh != null)
            {
                ViewBag.ThongBao = "Chúc mừng đăng nhập thành công";
                Session["Taikhoan"] = kh;
            }
            else
            {
                ViewBag.ThongBao = "Tên đăng nhập hoặc mật khẩu không đúng";
            }
            return RedirectToAction("ListSP", "MatHang");
        }
        public ActionResult ThongTin()
        {
            KhachHang kh = (KhachHang)Session["TaiKhoan"];
            return View(kh);
        }
        public ActionResult CSTT()
        {
            KhachHang kh = (KhachHang)Session["TaiKhoan"];
            return View(kh);


        }
        [HttpPost]
        public ActionResult CSTT(FormCollection fc)
        {
            KhachHang kh = (KhachHang)Session["TaiKhoan"];
            kh.diachi = fc["diachi"];
            kh.sdt = fc["sdt"];
            kh.email = fc["email"];
            data.SubmitChanges();
            return RedirectToAction("ThongTin");
        }
        public ActionResult DMK()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DMK(FormCollection fc)
        {
            var mkht = fc["mkht"];
            var mkm = fc["mkm"];
            var mkxn = fc["mkxn"];
            KhachHang kh = (KhachHang)Session["TaiKhoan"];
            if(String.IsNullOrEmpty(mkxn))
            {
                ViewData["nhapmkht"] = "không được bỏ trông mật khẩu hiện tại";
            }
            else if(!mkht.Equals(kh.matkhau))
            {
                ViewData["mkhtgiongnhau"] = " mật khẩu hiện tại không đúng";
            }
            else if(String.IsNullOrEmpty(mkm))
            {
                ViewData["nhapmkm"] = "không được bỏ trống mật khẩu mới";
            }
            else if(String.IsNullOrEmpty(mkxn))
            {
                ViewData["nhapmkxn"] = "không được bỏ trống mật khẩu xác nhận";
            }
            else if(!mkm.Equals(mkxn))
            {
                ViewData["mkxngiongnhau"] = "mật khẩu mới và mật khẩu xác nhận không giống nhau";
            }    
            else
            {
                kh.matkhau = mkm;
                data.SubmitChanges();
                return RedirectToAction("ThongTin");
            }
            return this.DMK();
        }
    }
}
using CHBQA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CHBQA.Controllers
{
    public class HomeController : Controller
    {
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
                return RedirectToAction("DangNhap", "Home");
            }
            return RedirectToAction("ListSP", "MatHang");
        }
        public ActionResult Index()
        {
            var all_sp = from ss in data.SanPhams select ss;
            return View(all_sp);
        }
        public ActionResult Detail(int id)
        {
            var matHang = data.SanPhams.Where(m => m.id_sp.Equals(id)).First();
            return View(matHang);
        }
        public List<GioHang> LayGioHang()
        {
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if (lstGioHang == null)
            {
                lstGioHang = new List<GioHang>();
                Session["GioHang"] = lstGioHang;
            }
            return lstGioHang;
        }
        private int TongSoLuong()
        {
            int tsl = 0;
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if (lstGioHang != null)
            {
                tsl = lstGioHang.Sum(n => n.iSoluong);
            }
            return tsl;
        }
        private int TongSoLuongSanPham()
        {
            int tsl = 0;
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if (lstGioHang != null)
            {
                tsl = lstGioHang.Count;
            }
            return tsl;
        }
        private double TongTien()
        {
            double tt = 0;
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            {
                if (lstGioHang != null)
                {
                    tt = lstGioHang.Sum(n => n.dThanhtien);
                }
                return tt;
            }
        }
        public ActionResult GioHang()
        {
            List<GioHang> lstGioHang = LayGioHang();
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = TongTien();
            ViewBag.Tongsoluongsanpham = TongSoLuongSanPham();
            return View(lstGioHang);
        }
        public ActionResult GioHangPartial()
        {
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = TongTien();
            ViewBag.Tongsoluongsanpham = TongSoLuongSanPham();
            return PartialView();
        }
    }
}
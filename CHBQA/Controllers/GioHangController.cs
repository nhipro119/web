using CHBQA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CHBQA.Controllers
{
    public class GioHangController : Controller
    {
        // GET: GioHang
        MyDataDataContext data = new MyDataDataContext();
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
        public ActionResult ThemGioHang(int id, string strURL)
        {
            List<GioHang> lstGioHang = LayGioHang();
            GioHang sanpham = lstGioHang.Find(n => n.id_sp.Equals(id));
            if (sanpham == null)
            {
                sanpham = new GioHang(id);
                lstGioHang.Add(sanpham);
                return Redirect(strURL);
            }
            else
            {
                sanpham.sl++;
                return Redirect(strURL);
            }
        }
        private int TongSoLuong()
        {
            int tsl = 0;
            List<GioHang> lstGioHang = Session["GioHang"] as List<GioHang>;
            if (lstGioHang != null)
            {
                tsl = lstGioHang.Sum(n => n.sl);
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
        [HttpGet]
        public ActionResult DatHang()
        {
            if (Session["Taikhoan"] == null || Session["Taikhoan"].ToString() == "")
            {
                return RedirectToAction("DangNhap", "NguoiDung");
            }

            if (Session["GioHang"] == null)
            {
                return RedirectToAction("ListSP", "MatHang");
            }
            List<GioHang> lstGioHang = LayGioHang();
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = TongTien();
            ViewBag.Tongsoluongsanpham = TongSoLuongSanPham();
            return View(lstGioHang);
        }
        [HttpPost]
        public ActionResult DatHang(FormCollection collection)
        {
            DDH dh = new DDH();
            KhachHang kh = (KhachHang)Session["taikhoan"];
            SanPham s = new SanPham();
            List<GioHang> gh = LayGioHang();
            dh.id_kh = kh.id_kh;
            dh.tg_tao = DateTime.Now;
            dh.sdt_kh = kh.sdt;
            dh.email_kh = kh.email;
            data.DDHs.InsertOnSubmit(dh);
            data.SubmitChanges();
            foreach (var item in gh)
            {
                CT_DDH ctdh = new CT_DDH();
                ctdh.id_ddh = dh.id_ddh;
                ctdh.id_sp = (item.id_sp).ToString();
                ctdh.sl = item.sl;
                ctdh.dongia = item.giaban;
                s = data.SanPhams.Single(n => n.id_sp == item.id_sp);
                s.sl -= ctdh.sl;
                data.SubmitChanges();
                data.CT_DDHs.InsertOnSubmit(ctdh);
            }
            data.SubmitChanges();
            Session["GioHang"] = null;
            return RedirectToAction("XacnhanDonhang", "GioHang");
        }
  
        public ActionResult XacnhanDonhang()
        {
            return View();
        }

        con cho khoa danh chet con cho thien;
    }
}
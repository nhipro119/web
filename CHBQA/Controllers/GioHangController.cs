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
                sanpham.iSoluong++;
                return Redirect(strURL);
            }
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
        [HttpGet]
        public ActionResult DatHang()
        {
            if (Session["Taikhoan"] == null || Session["Taikhoan"].ToString() == "")
            {
                return RedirectToAction("DangNhap", "NguoiDung");
            }
            List<GioHang> lstGioHang = LayGioHang();
            if (lstGioHang.Count < 1)
            {

                return RedirectToAction("ListSP", "MatHang");
            }
        
            ViewBag.Tongsoluong = TongSoLuong();
            ViewBag.Tongtien = TongTien();
            ViewBag.Tongsoluongsanpham = TongSoLuongSanPham();
            return View(lstGioHang);
        }
        [HttpPost]
        public ActionResult DatHang(FormCollection collection)
        {
            DDH dh = new DDH();
            KhachHang kh = (KhachHang)Session["Taikhoan"];
            SanPham s = new SanPham();
            List<GioHang> gh = LayGioHang();
            dh.id_kh = kh.id_kh;
            dh.tg_tao = DateTime.Now;
            dh.sdt_kh = kh.sdt;
            dh.email_kh = kh.email;
            double tongtien = 0;
            tongtien = TongTien();
            dh.tong_tien = int.Parse(tongtien.ToString());
            dh.trang_thai = 0;
            dh.diachi = kh.diachi;
            data.DDHs.InsertOnSubmit(dh);
            data.SubmitChanges();
            
            foreach (var item in gh)
            {
                CT_DDH ctdh = new CT_DDH();
                ctdh.id_ddh = dh.id_ddh;
                ctdh.id_sp = item.id_sp;
                ctdh.sl = item.iSoluong;
                ctdh.dongia = item.giaban;
                s = data.SanPhams.Single(n => n.id_sp == item.id_sp);
                s.sl -= ctdh.sl;
                tongtien += (item.iSoluong * item.giaban);
                data.SubmitChanges();
                data.CT_DDHs.InsertOnSubmit(ctdh);
            }
            data.SubmitChanges();
            Session["GioHang"] = null;
            return RedirectToAction("XacnhanDonhang", "GioHang");
        }

        public ActionResult CapNhatGioHang(int id, FormCollection collection)
        {
            List<GioHang> lstGiohang = LayGioHang();
            GioHang sanpham = lstGiohang.SingleOrDefault(n => n.id_sp == id);
            if (sanpham != null)
            {
                sanpham.iSoluong = int.Parse(collection["txtSoLg"].ToString());
            }
            return RedirectToAction("GioHang");
        }
        public ActionResult XoaGiohang(int id)
        {
            List<GioHang> lstGiohang = LayGioHang();
            GioHang sanpham = lstGiohang.SingleOrDefault(n => n.id_sp == id);
            if(sanpham != null)
            {
                lstGiohang.RemoveAll(n => n.id_sp == id);
                return RedirectToAction("GioHang");
            }
            return RedirectToAction("GioHang");
        }
        public ActionResult XoaTatCaGioHang()
        {
            List<GioHang> lstGiohang = LayGioHang();
            lstGiohang.Clear();
            return RedirectToAction("GioHang");
        }
        public ActionResult XacnhanDonhang()
        {
            return View();
        }
    }
}
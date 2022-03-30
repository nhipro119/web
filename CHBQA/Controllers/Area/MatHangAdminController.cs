using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CHBQA.Models;

namespace CHBQA.Controllers
{
    public class MatHangAdminController : Controller
    {
        // GET: MatHang
        MyDataDataContext data = new MyDataDataContext();

        public ActionResult ListSPAdmin()
        {
            var all_sp = from ss in data.SanPhams select ss;
            return View(all_sp);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection collection, SanPham s)
        {
            var E_tensp = collection["ten_sp"];
            var E_hinh1 = collection["hinh1"];
            var E_hinh2 = collection["hinh2"];
            var E_hinh3 = collection["hinh3"];
            var E_hinh4 = collection["hinh4"];
            var E_giaban = Convert.ToInt32(collection["giaban"]);
            var E_gianhap = Convert.ToDecimal(collection["gianhap"]);
            var E_sl = Convert.ToInt32(collection["sl"]);
            if (string.IsNullOrEmpty(E_tensp))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                s.ten_sp = E_tensp.ToString();
                s.hinh1 = E_hinh1.ToString();
                s.hinh2 = E_hinh2.ToString();
                s.hinh3 = E_hinh3.ToString();
                s.hinh4 = E_hinh4.ToString();
                s.giaban = E_giaban;
                s.sl = E_sl;
                data.SanPhams.InsertOnSubmit(s);
                data.SubmitChanges();
                return RedirectToAction("ListSPAdmin","MatHangAdmin");
            }
            return this.Create();
        }

        public ActionResult Delete(int id)
        {
            var D_sp = data.SanPhams.First(m => m.id_sp == id);
            return View(D_sp);
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var D_sp = data.SanPhams.Where(m => m.id_sp == id).First();
            data.SanPhams.DeleteOnSubmit(D_sp);
            data.SubmitChanges();
            return RedirectToAction("ListSPAdmin", "MatHangAdmin");
        }

        public ActionResult Edit(int id)
        {
            var E_sp = data.SanPhams.First(m => m.id_sp == id);
            return View(E_sp);
        }
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var E_sp = data.SanPhams.First(m => m.id_sp == id);
            var E_tensp = collection["ten_sp"];
            var E_giaban = Convert.ToInt32(collection["giaban"]);
            var E_gianhap = Convert.ToInt32(collection["gianhap"]);
            var E_ngaycapnhat = Convert.ToDateTime(collection["tg_tao"]);
            var E_sl = Convert.ToInt32(collection["sl"]);
            var E_hinh1 = collection["hinh1"];
            var E_hinh2 = collection["hinh2"];
            var E_hinh3 = collection["hinh3"];
            var E_hinh4 = collection["hinh4"];
            E_sp.id_sp = id;
            if (string.IsNullOrEmpty(E_tensp))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                E_sp.ten_sp = E_tensp;
                E_sp.giaban = E_giaban;
                E_sp.gianhap = E_gianhap;
                E_sp.tg_tao = E_ngaycapnhat;
                E_sp.sl = E_sl;
                E_sp.hinh1 = E_hinh1;
                E_sp.hinh2 = E_hinh2;
                E_sp.hinh3 = E_hinh3;
                E_sp.hinh4 = E_hinh4;
                UpdateModel(E_sp);
          //      data.SanPhams.InsertOnSubmit(E_sp);
                data.SubmitChanges();
                return RedirectToAction("ListSPAdmin", "MatHangAdmin");
            }
            return this.Edit(id);
        }

        public string ProcessUpload(HttpPostedFileBase file)
        {
            if (file == null)
            {
                return "";
            }
            file.SaveAs(Server.MapPath("~/Content/images/" + file.FileName));
            return "/Content/images/" + file.FileName;
        }
    }
}
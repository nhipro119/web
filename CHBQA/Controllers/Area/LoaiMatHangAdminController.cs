using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CHBQA.Models;

namespace CHBQA.Controllers
{
    public class LoaiMatHangAdminController : Controller
    {
        // GET: LoaiMatHang
        MyDataDataContext data = new MyDataDataContext();

        public ActionResult LoaimhAdmin()
        {
            var all_loaimh = from tt in data.LoaiHangs select tt;
            return View(all_loaimh);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection collection, LoaiHang lh)
        {
            var ten = collection["tenloai"];
            if (string.IsNullOrEmpty(ten))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                lh.ten_lh = ten;
                data.LoaiHangs.InsertOnSubmit(lh);
                data.SubmitChanges();
                return RedirectToAction("LoaimhAdmin","LoaiMatHangAdmin");
            }
            return this.Create();
        }

        public ActionResult Edit(int id)
        {
            var category = data.LoaiHangs.First(m => m.id_lh == id);
            return View(category);
        }

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            var theloai = data.LoaiHangs.First(m => m.id_lh == id);
            var E_tenloai = collection["tenloai"];
            theloai.id_lh = id;
            if (string.IsNullOrEmpty(E_tenloai))
            {
                ViewData["Error"] = "Don't empty!";
            }
            else
            {
                theloai.ten_lh = E_tenloai;
                UpdateModel(theloai);
                data.SubmitChanges();
                return RedirectToAction("LoaimhAdmin", "LoaiMatHangAdmin");
            }
            return this.Edit(id);
        }

        //-------------Delete-------------------
        public ActionResult Delete(int id)
        {
            var D_theloai = data.LoaiHangs.First(m => m.id_lh == id);
            return View(D_theloai);
        }
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            var D_theloai = data.LoaiHangs.Where(m => m.id_lh == id).First();
            data.LoaiHangs.DeleteOnSubmit(D_theloai);
            data.SubmitChanges();
            return RedirectToAction("LoaimhAdmin", "LoaiMatHangAdmin");
        }
    }
}
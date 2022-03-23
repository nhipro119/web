using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CHBQA.Models;

namespace CHBQA.Controllers
{
    public class MatHangController : Controller
    {
        // GET: MatHang
        MyDataDataContext data = new MyDataDataContext();

        public ActionResult ListSP()
        {
            var all_sp = from ss in data.SanPhams select ss;
            return View(all_sp);
        }

        public ActionResult Detail(int id)
        {
            var matHang = data.SanPhams.Where(m => m.id_sp.Equals(id)).First();
            return View(matHang);
        }
    }
}
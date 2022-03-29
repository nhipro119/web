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

        public ActionResult ListSP(string a ="",int id = -1, int gia = -1)
        {
            var all_sp = from ss in data.SanPhams select ss;
            if(id == -1)
            {

            }
            else
            {
                all_sp = from ss in all_sp where ss.id_lh == id select ss;
            }
            if(gia  == -1)
            {

            }
            else if(gia ==0)
            {
                all_sp = from ss in all_sp where ss.giaban < 100000 select ss;
            }
            else if (gia == 1)
            {
                all_sp = from ss in all_sp where ss.giaban < 500000 && ss.giaban >= 100000 select ss;
            }
            else if (gia == 2)
            {
                all_sp = from ss in all_sp where ss.giaban < 1000000 && ss.giaban >= 500000 select ss;
            }
            else if (gia == 3)
            {
                all_sp = from ss in all_sp where ss.giaban > 1000000 select ss;
            }
            all_sp = from sp in all_sp where sp.ten_sp.Contains(a) select sp;
            return View(all_sp);
        }
        [HttpPost]
        public ActionResult ListSP(FormCollection fc)
        {
            var timkiem = fc["search"];
            var list_sp = from sp in data.SanPhams where sp.ten_sp.Contains(timkiem) select sp;
            return View(list_sp);
        }
        public ActionResult Detail(int id)
        {
            var matHang = data.SanPhams.Where(m => m.id_sp.Equals(id)).First();
            return View(matHang);
        }
    }
}
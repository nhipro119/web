using CHBQA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CHBQA.Controllers
{
    public class ShopController : Controller
    {
        MyDataDataContext data = new MyDataDataContext();

        public ActionResult ListSP(int id = -1)
        {
            var all_sp = (from ss in data.SanPhams select ss).ToList();
            if (id == 0)
            {
                all_sp = (from sp in all_sp where sp.giaban < 100000 select sp).ToList();
            }
            else if (id == 1)
            {
                all_sp = (from sp in all_sp where sp.giaban >= 100000 && sp.giaban < 500000 select sp).ToList();
            }
            else if (id == 2)
            {
                all_sp = (from sp in all_sp where sp.giaban >= 500000 && sp.giaban < 1000000 select sp).ToList();
            }
            else if (id == 3)
            {
                all_sp = (from sp in all_sp where sp.giaban >= 1000000 select sp).ToList();
            }
            return View(all_sp);
        }
        public ActionResult SapXep( int id)
        {
            var all_sp = data.SanPhams.Where(b => b.id_lh == id);
            if(id == -1)
            {
                all_sp = data.SanPhams;
            }
            return View(all_sp);
        }
        public ActionResult SapXepGia(int id = -1)
        {
            var all_sp = data.SanPhams.ToList();
            
            return View(all_sp);
        }
        // GET: Shop
        public ActionResult Index()
        {
            return View();
        }
    }
}
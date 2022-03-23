using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CHBQA.Models;

namespace CHBQA.Controllers
{
    public class LoaiMatHangController : Controller
    {
        // GET: LoaiMatHang
        MyDataDataContext data = new MyDataDataContext();

        public ActionResult Index()
        {
            var all_loaimh = from tt in data.LoaiHangs select tt;
            return View(all_loaimh);
        }
    }
}
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

        public ActionResult ListSP()
        {
            var all_sp = from ss in data.SanPhams select ss;
            return View(all_sp);
        }
        // GET: Shop
        public ActionResult Index()
        {
            return View();
        }
    }
}
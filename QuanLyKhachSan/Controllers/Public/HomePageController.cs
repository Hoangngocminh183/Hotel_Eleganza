using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyKhachSan.Controllers.Public
{
    public class HomePageController : Controller
    {
        // GET: HomePage
        public ActionResult HomePage()
        {
            return View();
        }
    }
}
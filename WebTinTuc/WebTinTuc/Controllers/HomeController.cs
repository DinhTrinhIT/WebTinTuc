using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTinTuc.Models;

namespace WebTinTuc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        { 
        
            ViewBag.Hello="Hello Word";
            ViewData["XinChao"] = "Xin Chào";
            
            var model = new HelloModel();
            model.FirstName = "Trịnh";
            model.LastName = "Nguyễn Đình";

            return View(model);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult news()
        {
            ViewBag.Message = "Your news page.";

            return View();
        }
    }
}
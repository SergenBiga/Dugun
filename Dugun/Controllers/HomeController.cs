using Dugun.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dugun.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Slider() //Bu dşv id home kısmı
        {
            return View();
        }

        public ActionResult Story() 
        {
            return View();
        }

        public ActionResult Timer()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Wedding()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Rezervasyon() //Formu gösteren kısım.
        {
            return View();
        }

        [HttpPost] //Formu kaydeden kısım.
        public ActionResult Rezervasyon(Rezervasyon r) //bir şey kaydetmek için iki tane oluşturduk get gösteren post kaydedendir.
        {

            if (ModelState.IsValid)
            {
                r.IP = Request.ServerVariables["REMOTE_ADDR"]; //Kullanıcıdan gelen olduğu için
                ApplicationDbContext ctx = new ApplicationDbContext();
                ctx.Rezervasyonlar.Add(r);
                ctx.SaveChanges();
                ViewBag.sonuc = "TesekkurEt();";
            }

            return View();
        }
    }
}
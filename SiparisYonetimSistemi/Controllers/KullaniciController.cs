using SiparisYonetimSistemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiparisYonetimSistemi.Controllers
{
    public class KullaniciController : Controller
    {
        // GET: Kullanici
        public ActionResult Index()
        {
            return View(Veritabani.KullaniciListesi);
        }

        public ActionResult Kaydet()
        {
            return View(new Models.Kullanici());
        }

        [HttpPost]
        public ActionResult Kaydet(Models.Kullanici kullanici)
        {
            Veritabani.KullaniciListesi.Add(kullanici);
            return RedirectToAction("Index");
        }
    }
}
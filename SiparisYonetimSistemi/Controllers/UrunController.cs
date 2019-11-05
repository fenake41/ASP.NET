using SiparisYonetimSistemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiparisYonetimSistemi.Controllers
{
    public class UrunController : Controller
    {
        // GET: Urun
        public ActionResult Index()
        {
            return View(Veritabani.UrunListesi);
        }

        public ActionResult Kaydet()
        {
            return View(new Models.Urun());
        }

        [HttpPost]
        public ActionResult Kaydet(Models.Urun urun)
        {
            Veritabani.UrunListesi.Add(urun);
            return RedirectToAction("Index");
        }

        public ActionResult Duzenle(int id)
        {
            var urun = Veritabani.UrunListesi.Where(x => x.UrunId == id).SingleOrDefault();
            return View(urun);
        }

        [HttpPost]
        public ActionResult Duzenle(Models.Urun urun)
        {
            var stk = Veritabani.UrunListesi.Where(x => x.UrunId == urun.UrunId).SingleOrDefault();
            var index = Veritabani.UrunListesi.IndexOf(stk);
            Veritabani.UrunListesi[index] = urun;
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            Urun urun = Veritabani.UrunListesi.Where(x => x.UrunId == id).FirstOrDefault();
            Veritabani.UrunListesi.Remove(urun); 
       
            return RedirectToAction("Index");
        }

        public ActionResult Detay(int id)
        {
            var urun = Veritabani.UrunListesi.Where(x => x.UrunId == id).SingleOrDefault();
            return View(urun);
        }
    }
}
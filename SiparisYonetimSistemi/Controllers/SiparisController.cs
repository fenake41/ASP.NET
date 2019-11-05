using SiparisYonetimSistemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiparisYonetimSistemi.Controllers
{
    public class SiparisController : Controller
    {
        // GET: Siparis
        public ActionResult Index()
        {
            return View(Veritabani.SiparisListesi);
        }
        public ActionResult Kaydet()
        {
            return View(new Models.Siparis()); 
        }
        [HttpPost]
        public ActionResult Kaydet(Models.Siparis siparis)
        {
            Veritabani.SiparisListesi.Add(siparis);
            return RedirectToAction("Index");
        }
        public ActionResult Duzenle(int id)
        {
            var siparis = Veritabani.SiparisListesi.Where(x => x.SiparisId == id).SingleOrDefault();
            return View(siparis);
        }

        [HttpPost]
        public ActionResult Duzenle(Models.Siparis  siparis)
        {
            var stk = Veritabani.SiparisListesi.Where(x => x.SiparisId == siparis.SiparisId).SingleOrDefault();
            var index = Veritabani.SiparisListesi.IndexOf(stk);
            Veritabani.SiparisListesi[index] = siparis;
            return RedirectToAction("Index");
        }

        public ActionResult Sil(int id)
        {
            Siparis siparis = Veritabani.SiparisListesi.Where(x => x.SiparisId == id).FirstOrDefault();
            Veritabani.SiparisListesi.Remove(siparis);

            return RedirectToAction("Index");
        }

        public ActionResult Detay(int id)
        {
            var siparis = Veritabani.SiparisListesi.Where(x => x.SiparisId == id).SingleOrDefault();
            return View(siparis);
        }
    }
}
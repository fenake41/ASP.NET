using SiparisYonetimSistemi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiparisYonetimSistemi.Controllers
{
    public class MusteriController : Controller
    {
        // GET: Musteri
        public ActionResult Index()
        {
            return View(Veritabani.MusteriListesi);
        }
        
        public ActionResult Kaydet()
        {
            ViewBag.Il = Veritabani.IlGetir();
            ViewBag.Ilce = Veritabani.IlceGetir();
            return View(new Models.Musteri());
        }
        [HttpPost]
        public ActionResult Kaydet(Models.Musteri musteri)
        {
            Veritabani.MusteriListesi.Add(musteri);
            return RedirectToAction("Index");
        }
        public ActionResult Duzenle(int id)
        {
            var musteri = Veritabani.MusteriListesi.Where(x => x.MusteriId == id).SingleOrDefault();
            return View(musteri);
        }
        [HttpPost]
        public ActionResult Duzenle(Models.Musteri musteri)
        {
            var mst = Veritabani.MusteriListesi.Where(x => x.MusteriId == musteri.MusteriId).SingleOrDefault();
            var index = Veritabani.MusteriListesi.IndexOf(mst);
            Veritabani.MusteriListesi[index] = musteri;
            return RedirectToAction("Index");
        }
        public ActionResult Detay(int id)
        {
            var detay = Veritabani.MusteriListesi.Where(x => x.MusteriId == id).FirstOrDefault();
            return View(detay);
        }
        public ActionResult Sil(int id)
        {
            Musteri musteri = Veritabani.MusteriListesi.Where(x => x.MusteriId == id).FirstOrDefault();
            Veritabani.MusteriListesi.Remove(musteri);

            return RedirectToAction("Index");
        }
    }
}
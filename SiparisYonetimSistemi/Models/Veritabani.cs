using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiparisYonetimSistemi.Models
{
    public class Veritabani
    {
        public static List<Urun> UrunListesi = new List<Urun>();
        public static List<Musteri> MusteriListesi = new List<Musteri>();
        public static List<Siparis> SiparisListesi = new List<Siparis>();
        public static List<Kullanici> KullaniciListesi = new List<Kullanici>();

        public static List<Il> IlGetir()
        {
            var liste = new List<Il>
            {
                new Il()
                {
                    IlId = 1,
                    IlAdi ="Kocaeli"
                },
                new Il()
                {
                    IlId = 2,
                    IlAdi ="İstanbul"
                },
                 new Il()
                {
                    IlId = 3,
                    IlAdi ="Bursa"
                },
                  new Il()
                {
                    IlId = 4,
                    IlAdi ="Sakarya"
                }
            };
            return liste;
        }
        public static List<Ilce> IlceGetir()
        {
            var liste = new List<Ilce>
            {
                new Ilce()
                {
                    IlceId = 1,
                    IlceAdi ="İzmit"
                },
                new Ilce()
                {
                    IlceId = 2,
                    IlceAdi ="Gebze"
                },
                 new Ilce()
                {
                    IlceId = 3,
                    IlceAdi ="Pendik"
                },
                  new Ilce()
                {
                    IlceId = 4,
                    IlceAdi ="Ümraniye"
                },
                   new Ilce()
                {
                    IlceId = 5,
                    IlceAdi ="Küçükçekmece"
                },
                    new Ilce()
                {
                    IlceId = 6,
                    IlceAdi ="Osmangazi"
                },
                     new Ilce()
                {
                    IlceId = 7,
                    IlceAdi ="Adapazarı"
                },
            };
            return liste;
        }
    }
}
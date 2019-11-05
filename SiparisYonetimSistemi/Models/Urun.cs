using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiparisYonetimSistemi.Models
{
    public class Urun
    {
        public int UrunId { get; set; }
        public string UrunAdi { get; set; }
        public int StokKodu { get; set; }
        public float AlisFiyat { get; set; }
        public float SatisFiyat { get; set; }
        public Boolean UrunDurum { get; set; }
        public string Aciklama { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiparisYonetimSistemi.Models
{
    public class Siparis
    {
        public byte SiparisId { get; set; }
        public byte MusteriId { get; set; }
        public float ToplamTutar { get; set; }
        public DateTime KayitZamani { get; set; }
        public byte SiparisDetayId { get; set; }
        public byte UrunId { get; set; }
        public int Miktar { get; set; }
        public float BirimFiyat { get; set; }
        public float Toplam { get; set; }

    }

   
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiparisYonetimSistemi.Models
{
    public class Kullanici
    {
        [Required()]
        public int KullaniciId { get; set; }
        public string KullaniciAdi { get; set; }
        public string KullaniciSoyadi { get; set; }
        public string Parola { get; set; }
        public string Email { get; set; }
    }
}
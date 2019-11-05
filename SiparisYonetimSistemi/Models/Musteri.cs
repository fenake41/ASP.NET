using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SiparisYonetimSistemi.Models
{
    public class Musteri
    {
        [DisplayName("Kullanıcı Id"), Required(ErrorMessage = "Kullanıcı Id Giriniz.")]
        public int MusteriId { get; set; }

        [DisplayName("Kullanıcı Adı"), Required(ErrorMessage = "Kullanıcı Adı Giriniz.")]
        public string MusteriAdi { get; set; }

        [DisplayName("Kullanıcı Soyadı"), Required(ErrorMessage = "Kullanıcı Soyadı Giriniz.")]
        public string MusteriSoyadi { get; set; }

        public byte IlId { get; set; }
        public byte IlceId { get; set; }
        public string Adres { get; set; }
    }
   
}
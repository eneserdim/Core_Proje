using System;
using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Customers
    {
        [Key]
        public int CariID { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string VerilenHizmet { get; set; }
        public decimal AnlaşılanÜcret { get; set; }
        public decimal Maliyet { get; set; }
        public DateTime Tarih { get; set; }
        public string Açıklama { get; set; }

    }
}

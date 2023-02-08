using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Makale
    {
        public int ID { get; set; }
        public int kategoriID { get; set; }
        public string kategori { get; set; }
        public int yoneticiID { get; set; }
        public string yonetici { get; set; }
        public string baslik { get; set; }
        public string ozet { get; set; }
        public string icerik { get; set; }
        public string resim { get; set; }
        public int goruntulemeSayisi { get; set; }
        public DateTime eklemeTarihi { get; set; }
        public int begeniSayisi { get; set; }
        public bool durum { get; set; }
        public string YayindaStr { get; set; }
        public string EklemeTarihStr { get; set; }
    }
}

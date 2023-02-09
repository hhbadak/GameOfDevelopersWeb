using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Uye
    {
        public int ID { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
        public string mail { get; set; }
        public bool durum { get; set; }
        public string durumStr { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Yorum
    {
        public int ID { get; set; }
        public int uyeID { get; set; }
        public string uye { get; set; }
        public int makaleID { get; set; }
        public string makale { get; set; }
        public int yoneticiID { get; set; }
        public string yonetici { get; set; }
        public string icerik { get; set; }
        public bool durum { get; set; }
    }
}

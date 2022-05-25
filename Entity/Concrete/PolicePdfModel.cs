using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class PolicePdfModel :IEntity
    {
        public string KimlikNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Uyruk { get; set; }
        public string UlkeAd { get; set; }
        public string DogumYeri { get; set; }
        public string ZeylTip { get; set; }
        public string UzunAd { get; set; }
    }
}

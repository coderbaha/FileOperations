using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    [Table("VKFE20220513030052.txt")]
    public class VKFE : IEntity
    {
        [StringLength(1)]
        public string Brans { get; set; }

        [StringLength(15)]
        public string SayacNo { get; set; }

        [StringLength(15)]
        public string Police { get; set; }

        [StringLength(10)]
        public string Donem { get; set; }

        [StringLength(5)]
        public string BorcTipi { get; set; }

        [StringLength(21)]
        public string Tutar { get; set; }

        [StringLength(50)]
        public string AdSoyad { get; set; }

        [StringLength(15)]
        public string HataKodu { get; set; }

    }
}

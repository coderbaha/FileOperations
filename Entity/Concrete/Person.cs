using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    [Table("agito.t_person.xls")]
    public class Person : IEntity
    {
        public long Pid { get; set; }
        public string Tg { get; set; }
        public string Pertip { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Sirket { get; set; }
        public string Cins { get; set; }
        public string DogTar { get; set; }
        public string BabaAdi { get; set; }
        public string BankaId { get; set; }
        public string Vip { get; set; }
        public string VipAciklama { get; set; }
        public string VergiNo { get; set; }
        public string KimlikNo { get; set; }
        public string CrtUsr { get; set; }
        public string CrtTar { get; set; }
        public string UpdUsr { get; set; }
        public string UpdTar { get; set; }
        public string TksSicilNo { get; set; }
        public string AnaAdi { get; set; }
        public string AnaKizlikSoyadi { get; set; }
        public string Uyruk { get; set; }
        public string GsmNo { get; set; }
        public string SirketTip { get; set; }
        public string TicSicilNo { get; set; }
        public string Sifre { get; set; }
        public string IlkEmekSozNo { get; set; }
        public string EmekGirTar { get; set; }
        public string IlgiliKisi { get; set; }
        public string IlgiliKisiTel { get; set; }
        public string KisiSicilNo { get; set; }
        public string VergiDairesi { get; set; }
        public string MedeniHal { get; set; }
        public string Vefat { get; set; }
        public string SicilNo { get; set; }
        public string SandikNo { get; set; }
        public string AkaRowId { get; set; }
        public string PvId { get; set; }
        public string Meslek { get; set; }
        public string UlkeUyruk { get; set; }
        public string BankaMusteriNo { get; set; }
        public string Language { get; set; }
        public string UlkeId { get; set; }
        public string DogUlkeId { get; set; }
        public string DogIlId { get; set; }
        public string DogIlceId { get; set; }
        public string ProfileId { get; set; }
        public string Segment { get; set; }
        public string AltSegment { get; set; }
        public string IsyeriSicilNo { get; set; }
        public string MaviKartNo { get; set; }
        public string KayipMusteri { get; set; }
        public string VersionId { get; set; }
        public string UlkeAd { get; set; }
        public string DogUlkeAd { get; set; }
        public string DogIlAd { get; set; }
        public string DogIlceAd { get; set; }
        public string MaviKartBasTar { get; set; }
        public string DogumYeri { get; set; }
        public string TksSicilAd { get; set; }
        public string TksSicilAdSoyad { get; set; }
        public string UlkeId2 { get; set; }
        public string KimlinNo2 { get; set; }
        public string VergiNo2 { get; set; }
        public string OturumIzniUlkeId { get; set; }
        public string CalismaIzniUlkeId { get; set; }
        public string GreenCardVarMi { get; set; }
        public string AbdUyrukluHissedarVarMi { get; set; }
        public string YurtDisiCalismaIzniVarMi { get; set; }
        public string YurtDisiOturumIzniVarMi { get; set; }
        public string W9Onay { get; set; }
        public string IliskiliTaraf { get; set; }
        public string NSirket { get; set; }
        public string NAd { get; set; }
        public string NSoyad { get; set; }
        public string MaviKartBeyanTar { get; set; }
        public string KetVergiNo { get; set; }
        public string SegmentId { get; set; }
        public string EkPkkTahsilat { get; set; }
    }
}

using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    [Table("agito.t_sigortali.xls")]
    public class Sigortali : IEntity
    {
        public long PolId { get; set; }
        public string ZeylNo { get; set; }
        public long Pid { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string DogTar { get; set; }
        public string Cins { get; set; }
        public string BireyTip { get; set; }
        public string IlkGirTar { get; set; }
        public string RiskSnf { get; set; }
        public string Ek2 { get; set; }
        public string KatNo { get; set; }
        public string TemSnf { get; set; }
        public string YenilemeTip { get; set; }
        public string Ihtiyari { get; set; }
        public string BankaId { get; set; }
        public string SicilNo { get; set; }
        public string BasvuruNo { get; set; }
        public string BasvuruTar { get; set; }
        public string BasSonStatus { get; set; }
        public string BasSonStatusTar { get; set; }
        public string HesapPrim { get; set; }
        public string HesapBsmv { get; set; }
        public string IsOran { get; set; }
        public string PosKartNo { get; set; }
        public string AdresId { get; set; }
        public string Adet { get; set; }
        public string SgAktıf { get; set; }
        public string MortSnf { get; set; }
        public string TmntKat { get; set; }
        public string DemoSeq { get; set; }
        public string KpOran { get; set; }
        public string MedId { get; set; }
        public string CrtUsr { get; set; }
        public string CrtTar { get; set; }
        public string UpdUsr { get; set; }
        public string UpdTar { get; set; }
        public string PosKartSiraNo { get; set; }
        public string DagitimNo { get; set; }
        public string MaasTutar { get; set; }
        public string MaasOran { get; set; }
        public string SandikNo { get; set; }
        public string OkulNo { get; set; }
        public string AkaRowId { get; set; }
        public string PvId { get; set; }
        public string TariffPackageId { get; set; }
        public string BasvuruSeriNo { get; set; }
        public string VersionId { get; set; }
        public string HakedisBasTar { get; set; }
        public string UyeTip { get; set; }
        public string SgkdanEmekli { get; set; }
        public string NAd { get; set; }
        public string NSoyad { get; set; }
        public string ReferansPid { get; set; }
        public string ReferansYakinlik { get; set; }
        public string HesapGuvenceHesabi { get; set; }
        public string KanuniTemsilciPid { get; set; }
        public string YakinlikDerecesi { get; set; }
        public string IsRoboFonKarma { get; set; }
        public string RoboNeighBoringSystem { get; set; }
    }
}

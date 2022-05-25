using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    [Table("agito.t_police.xls")]
    public class Police : IEntity
    {
        public long PolId { get; set; }
        public string PolCins { get; set; }
        public string PolTip { get; set; }
        public string GrupTip { get; set; }
        public string BransKod { get; set; }
        public string UrunKod { get; set; }
        public string Ver { get; set; }
        public string PoliceNo { get; set; }
        public string AileNo { get; set; }
        public string YenilemeNo { get; set; }
        public string SiraNo { get; set; }
        public string PolBasTar { get; set; }
        public string PolBitTar { get; set; }
        public string PolTanTar { get; set; }
        public string SonZeylNo { get; set; }
        public string Status { get; set; }
        public string SubStatus { get; set; }
        public string EskiPolId { get; set; }
        public string YeniPolId { get; set; }
        public string EskiSisPolNo { get; set; }
        public string ProvStatus { get; set; }
        public string IhtarStatus { get; set; }
        public string Ek1 { get; set; }
        public string PrimPay { get; set; }
        public string KayitTar { get; set; }
        public string Aciklama { get; set; }
        public string TazKacGun { get; set; }
        public string TazHaftaGun { get; set; }
        public string DovKod { get; set; }
        public string MedGirNo { get; set; }
        public string DagitimNo { get; set; }
        public string ProtokolNo { get; set; }
        public string TeklifId { get; set; }
        public string CrtUsr { get; set; }
        public string CrtTar { get; set; }
        public string UpdUsr { get; set; }
        public string UpdTar { get; set; }
        public string Yuvarla { get; set; }
        public string TazOdeme { get; set; }
        public string NotId { get; set; }
        public string CayBedeli { get; set; }
        public string KomOdeTip { get; set; }
        public string YetkiSeviye { get; set; }
        public string CayOran { get; set; }
        public string IlkEmekSozNo { get; set; }
        public string EmekGirTar { get; set; }
        public string DevirMi { get; set; }
        public string HesapNo { get; set; }
        public string HesapSirketNo { get; set; }
        public string DevirHesapNo { get; set; }
        public string DevirHesapSirketNo { get; set; }
        public string DevirHesapSozTar { get; set; }
        public string AkaRowId { get; set; }
        public string MutemetKod { get; set; }
        public string HasLife { get; set; }
        public string LifePolNo { get; set; }
        public string YururlulukTar { get; set; }
        public string IlkVadeTar { get; set; }
        public string SatisTip { get; set; }
        public string HizSozForVarMi { get; set; }
        public string EmeklilikTar { get; set; }
        public string StatuNeden { get; set; }
        public string GadovKod { get; set; }
        public string VersionId { get; set; }
        public string NStatuNeden { get; set; }
        public string BesGirTar { get; set; }
        public string DkBasTar { get; set; }
        public string IlkGirTar { get; set; }
        public string OksBilTar { get; set; }
        public string OksDurum { get; set; }
        public string IsProvZeyl { get; set; }
        public string IsProvOdePlan { get; set; }
        public string IsProvManuel { get; set; }
        public string ProvOdeTipTur { get; set; }
        public string TefasBeyanTar { get; set; }
    }
}

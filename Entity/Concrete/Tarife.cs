using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    [Table("agito.tarife.xls")]
    public class Tarife : IEntity
    {
        public string BransKod { get; set; }
        public string TarifeNo { get; set; }
        public string UrunKod { get; set; }
        public string KisaAd { get; set; }
        public string UzunAd { get; set; }
        public string TescilTar { get; set; }
        public string Gf { get; set; }
        public string KartFlg { get; set; }
        public string SonZeylNo { get; set; }
        public string Status { get; set; }
        public string Ek1Ad { get; set; }
        public string Ek2Ad { get; set; }
        public string ZeylTips { get; set; }
        public string IkrazTips { get; set; }
        public string ZimTip { get; set; }
        public string DovList { get; set; }
        public string KurCins { get; set; }
        public string TzmKurCins { get; set; }
        public string TekPrim { get; set; }
        public string Katli { get; set; }
        public string KatBase { get; set; }
        public string ReasFlg { get; set; }
        public string HasIhtar { get; set; }
        public string HasAile { get; set; }
        public string NonStdRisk { get; set; }
        public string NonStdTab { get; set; }
        public string ReasekThk { get; set; }
        public string TazHesap { get; set; }
        public string ProtoNo { get; set; }
        public string ProtoZeylNo { get; set; }
        public string IsTeklif { get; set; }
        public string CrtUsr { get; set; }
        public string CrtTar { get; set; }
        public string UpdUsr { get; set; }
        public string UpdTar { get; set; }
        public string NotId { get; set; }
        public string YetkiSeviye { get; set; }
        public string KomOdeTip { get; set; }
        public string RiskKtgr { get; set; }
        public string Xls { get; set; }
        public string RaporAd { get; set; }
        public string IsEndW { get; set; }
        public string CalCcri { get; set; }
        public string UzunSureliRisk { get; set; }
        public string YillikThk { get; set; }
        public string AkaRowId { get; set; }
        public string OdeSureFarkli { get; set; }
        public string SaglikAnketNo { get; set; }
        public string PasatIs { get; set; }
        public string RsHesap { get; set; }
        public string SUurecTip { get; set; }
        public string AylikAzalan { get; set; }
        public string BasTar { get; set; }
        public string TaraflarAyni { get; set; }
        public string Kredili { get; set; }
        public string DainiMurtehin { get; set; }
        public string BitTar { get; set; }
        public string AktarOzelEmkFlg { get; set; }
        public string OdSurOranLimiti { get; set; }
        public string DynamicDEduction { get; set; }
        public string IsLifeCycleAssetMng { get; set; }
        public string BrkUrunTipi { get; set; }
        public string VersionId { get; set; }
        public string IsEgp { get; set; }
        public string PlanGecis { get; set; }
        public string VavifAktarim { get; set; }
        public string VakifAktarimTip { get; set; }
        public string VakifTip { get; set; }
        public string HesBirlesZorunlu { get; set; }
        public string AsgariKpArtisTipi { get; set; }
        public string YgkLimitEndeksTipi { get; set; }
        public string AzalanKapitalTipi { get; set; }
        public string Tekaful { get; set; }
        public string IsOks { get; set; }
        public string PolCins { get; set; }
        public string IlkVadeBaslangic { get; set; }
        public string ReferansKontrol { get; set; }
        public string IsAile { get; set; }
        public string IsTefas { get; set; }
        public string IsKatılım { get; set; }
        public string KrediBilgiZorunlu { get; set; }
    }
}

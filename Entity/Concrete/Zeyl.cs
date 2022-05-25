using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entity.Concrete
{
    [Table("agito.t_zeyl.xls")]
    public class Zeyl : IEntity  
    {
        public long PolId { get; set; }
        public string ZeylNo { get; set; }
        public string GrupZeylNo { get; set; }
        public string ZeylTip { get; set; }
        public string MektupNo { get; set; }
        public string HoldingId { get; set; }
        public string GrupId { get; set; }
        public string AcenteNo { get; set; }
        public string ElemanNo { get; set; }
        public string BasTar { get; set; }
        public string Sure { get; set; }
        public string BitTar { get; set; }
        public string TanTar { get; set; }
        public string RejiTar { get; set; }
        public string SigetId { get; set; }
        public string AdresId { get; set; }
        public string VergiNo { get; set; }
        public string VergiDairesi { get; set; }
        public string OdeTip { get; set; }
        public string FonKod { get; set; }
        public string OdeDodem { get; set; }
        public string NetPrim { get; set; }
        public string Bsmv { get; set; }
        public string ArtOran { get; set; }
        public string ArtTip { get; set; }
        public string Notlar { get; set; }
        public string Stat { get; set; }
        public string GrpInd { get; set; }
        public string TaksInd { get; set; }
        public string HasarPrim { get; set; }
        public string Iao { get; set; }
        public string TaksSeq { get; set; }
        public string TarifeZeylNo { get; set; }
        public string YilPrim { get; set; }
        public string HesapNo { get; set; }
        public string KarAcenteNo { get; set; }
        public string NwNum { get; set; }
        public string SiraNo { get; set; }
        public string CrtUsr { get; set; }
        public string CrtTar { get; set; }
        public string UpdUsr { get; set; }
        public string UpdTar { get; set; }
        public string CariTakip { get; set; }
        public string SureTip { get; set; }
        public string EskisiSZeylNo { get; set; }
        public string SeriNo { get; set; }
        public string FonMetodId { get; set; }
        public string GaTutar { get; set; }
        public string GaOdeDonem { get; set; }
        public string ZeylNeden { get; set; }
        public string TaksitTipi { get; set; }
        public string GaTaksitTipi { get; set; }
        public string GaErtele { get; set; }
        public string Ga { get; set; }
        public string ThsMasraf { get; set; }
        public string KtpHspTip { get; set; }
        public string KtpDegDonem { get; set; }
        public string MinPlanDeg { get; set; }
        public string KtpSablonKod { get; set; }
        public string GaSablonKod { get; set; }
        public string PesOran { get; set; }
        public string GaPesOran { get; set; }
        public string ThsMasrafGa { get; set; }
        public string BransKod { get; set; }
        public string TarifeNo { get; set; }
        public string KadroNo { get; set; }
        public string BazPrim { get; set; }
        public string PlanDeg { get; set; }
        public string IsKolu { get; set; }
        public string AkaRowId { get; set; }
        public string OdeSure { get; set; }
        public string AcnRefNo { get; set; }
        public string AcnRefKomOran { get; set; }
        public string PvId { get; set; }
        public string ResmiAraci { get; set; }
        public string OdemeGun { get; set; }
        public string SorumluKaynakId { get; set; }
        public string FonMetodIdDk { get; set; }
        public string DiffMetodId { get; set; }
        public string DiffMetodIdDk { get; set; }
        public string TalepEden { get; set; }
        public string AcenteTarihceId { get; set; }
        public string ElemanTarihceId { get; set; }
        public string TenzilTipi { get; set; }
        public string VersionId { get; set; }
        public string YenilemeDrm { get; set; }
        public string TalepEdenPid { get; set; }
        public string EvrakTamamTar { get; set; }
        public string YenilemeYil { get; set; }
        public string UygulamaSekli { get; set; }
        public string Temlik { get; set; }
        public string KaraIstirakOrani { get; set; }
        public string KaraIstirakTipi { get; set; }
        public string IgesFonGbbde { get; set; }
        public string KanalId { get; set; }
        public string KanalTarihceId { get; set; }
        public string FreeCoverLimit { get; set; }
        public string BesBirikimHedefi { get; set; }
        public string PolTanTar { get; set; }
        public string TeklifSeq { get; set; }
        public string GecVadeDuzTut { get; set; }
        public string IsFaizsiz { get; set; }
        public string AraVerBitTar { get; set; }
        public string Gonderim { get; set; }
        public string IsAyrilTar { get; set; }
        public string UcretsizDonemBasTar { get; set; }
        public string UcretsizDonemBitTar { get; set; }
        public string AltSigetId { get; set; }
        public string OksKesintiOran { get; set; }
        public string IhtarKumesineCiksin { get; set; }
        public string IhtarnameGonder { get; set; }
        public string IhtaraKonuDegil { get; set; }
        public string PolicySurveyDetailId { get; set; }
        public string KrediNo { get; set; }
        public string CalisanIsverenIliskiYok { get; set; }
        public string GuvenceHesabi { get; set; }
        public string MutabakatBasGun { get; set; }
        public string MutabakatListesiGonder { get; set; }
        public string MutabakataKonuIslemler { get; set; }
        public string VarisPaylasim { get; set; }
        public string AlternatifOdeTip { get; set; }
        public string GrupTalimatBankaId { get; set; }
        public string IsteFas { get; set; }
        public string FatcaCrsKapsamında { get; set; }
    }
}

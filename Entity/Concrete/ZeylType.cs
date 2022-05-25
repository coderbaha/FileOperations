using Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    [Table("agito.zeyltips.xls")]
    public class ZeylType : IEntity
    {
        public string ZeylTip { get; set; }
        public string Aciklama { get; set; }
        public string PrimDeg { get; set; }
        public string MektupBas { get; set; }
        public string BagStatList { get; set; }
        public string DegStat { get; set; }
        public string PhTip { get; set; }
        public string BagZeylTips { get; set; }
        public string SgAktif { get; set; }
        public string Hedef { get; set; }
        public string Sira { get; set; }
        public string CrtUsr { get; set; }
        public string CrtTar { get; set; }
        public string UpdUsr { get; set; }
        public string UpdTar { get; set; }
        public string Uw { get; set; }
        public string FileName { get; set; }
        public string ListName { get; set; }
        public string BransList { get; set; }
        public string PhFormul { get; set; }
        public string Reas { get; set; }
        public string AkaRowId { get; set; }
        public string Limit { get; set; }
        public string AciklamaZorunluluk { get; set; }
        public string ZeylSrc { get; set; }
        public string SonKural { get; set; }
        public string OnKural { get; set; }
        public string HesapTip { get; set; }
        public string CheckRule { get; set; }
        public string AssignmentRule { get; set; }
        public string OdePlanDeg { get; set; }
        public string Egp { get; set; }
        public string GrupId { get; set; }
        public string HakSahipligiKonu { get; set; }
        public string VersionId { get; set; }
        public string PostRule { get; set; }
        public string Kod { get; set; }
        public string HaymerCheck { get; set; }
        public string GevCheck { get; set; }
        public string HaymerKod { get; set; }
        public string GevKod { get; set; }
        public string TopluZeyl { get; set; }
        public string GrupZeyş { get; set; }
        public string CancelRule { get; set; }
        public string NotificationFunctionId { get; set; }
        public string YatEmirTip { get; set; }
        public string YatEmirTipDk { get; set; }
        public string Tac { get; set; }
        public string TahsiAde { get; set; }
        public string PermissionId { get; set; }
        public string Puan { get; set; }
        public string AutoEndorsement { get; set; }
        public string IleriTatihliZeyl { get; set; }
    }
}

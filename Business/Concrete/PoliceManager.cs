using Entity.Concrete;
using Helper;
using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper.FilePaths;

namespace Business.Concrete
{
    public class PoliceManager : IPoliceService
    {
        public static List<Police> _policeList = new List<Police>();
        public static List<Zeyl> _zeylList = new List<Zeyl>();
        public static List<ZeylType> _zeylTypeList = new List<ZeylType>();
        public static List<Tarife> _tarifeTypeList = new List<Tarife>();

        public void PoliceTypes()
        {
            try
            {
                _policeList.AddRange(ExcelConnection<Police>.GetExcelData());
                var ferdiKaza = _policeList.Where(x => x.BransKod.Equals("K")).ToList().Count;
                var hayat = _policeList.Where(x => x.BransKod.Equals("H")).ToList().Count;
                var emeklilik = _policeList.Where(x => x.BransKod.Equals("E")).ToList().Count;
                string data = "Ferdi Kaza: {0}, Hayat: {1}, Emeklilik: {2}";
                Console.WriteLine(string.Format(data, ferdiKaza, hayat, emeklilik));
            }
            catch (Exception e)
            {
                FileLogHelper.LogFile(FilePath.TRYCATCHLOGFILENAME,
                        e.Message.ToString());
            }
        }
        public void TariffNoAndExplanation()
        {
            try
            {
                _policeList.AddRange(ExcelConnection<Police>.GetExcelData());
                _zeylList.AddRange(ExcelConnection<Zeyl>.GetExcelData());
                _tarifeTypeList.AddRange(ExcelConnection<Tarife>.GetExcelData());
                var query = from p in _policeList
                            join z in _zeylList
                                 on p.PolId equals z.PolId
                            join t in _tarifeTypeList
                                 on z.TarifeNo equals t.TarifeNo
                            select new
                            {
                                t.UzunAd,
                                z.TarifeNo
                            };
                var result = query.GroupBy(x => new { x.TarifeNo, x.UzunAd }).Select(y => new { y.Key.UzunAd }).ToList();
                Console.WriteLine(string.Format("{0} farklı tarife numarasına ait poliçe mevcut.", result.Count()));
                foreach (var item in result)
                {
                    string products = "Tarife açıklama: {0}";
                    Console.WriteLine(string.Format(products, item.UzunAd));
                }
            }
            catch (Exception e)
            {
                FileLogHelper.LogFile(FilePath.TRYCATCHLOGFILENAME,
                        e.Message.ToString());
            }
        }
        public void ZeylTypesAndExplanation()
        {
            try
            {
                _policeList.AddRange(ExcelConnection<Police>.GetExcelData());
                _zeylList.AddRange(ExcelConnection<Zeyl>.GetExcelData());
                _zeylTypeList.AddRange(ExcelConnection<ZeylType>.GetExcelData());
                var query = from p in _policeList
                            join z in _zeylList
                                 on p.PolId equals z.PolId
                            join zt in _zeylTypeList
                                 on z.ZeylTip equals zt.ZeylTip
                            select new
                            {
                                z.ZeylTip,
                                zt.Aciklama
                            };
                var result = query.GroupBy(x => new { x.ZeylTip, x.Aciklama }).Select(y => new { y.Key.Aciklama }).ToList();
                Console.WriteLine(string.Format("{0} farklı zeyl tipinde poliçe mevcut.", result.Count()));
                foreach (var item in result)
                {
                    string products = "Zeyl tip açıklama: {0}";
                    Console.WriteLine(string.Format(products, item.Aciklama));
                }
            }
            catch (Exception e)
            {
                FileLogHelper.LogFile(FilePath.TRYCATCHLOGFILENAME,
                        e.Message.ToString());
            }
        }
    }
}

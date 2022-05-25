using Business.Abstract;
using Entity.Concrete;
using Helper;
using Helper.FilePaths;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class GenericPdfManager : IGenericPdfService
    {
        public static List<Police> _policeList = new List<Police>();
        public static List<Sigortali> _sigortaliList = new List<Sigortali>();
        public static List<Person> _personList = new List<Person>();
        public static List<Tarife> _tarifeList = new List<Tarife>();
        public static List<Zeyl> _zeylList = new List<Zeyl>();

        public void PoliceToPdf()
        {
            try
            {
                _policeList.AddRange(ExcelConnection<Police>.GetExcelData());
                _sigortaliList.AddRange(ExcelConnection<Sigortali>.GetExcelData());
                _personList.AddRange(ExcelConnection<Person>.GetExcelData());
                _tarifeList.AddRange(ExcelConnection<Tarife>.GetExcelData());
                _zeylList.AddRange(ExcelConnection<Zeyl>.GetExcelData());
                
                var pdfModel = new List<PolicePdfModel>();

                var query = from p in _policeList
                            join z in _zeylList
                                 on p.PolId equals z.PolId
                            join x in _sigortaliList
                                on z.PolId equals x.PolId
                            join y in _personList
                                on x.Pid equals y.Pid
                            join c in _tarifeList
                                on z.TarifeNo equals c.TarifeNo
                            select new
                            {
                                y.Ad,y.Soyad,y.KimlikNo,y.DogumYeri,y.Uyruk,y.UlkeAd,z.ZeylTip,c.UzunAd
                            };

                foreach(var item in query.ToList().Distinct())
                {
                    var encryptedKimlikNo = !string.IsNullOrEmpty(item.KimlikNo) ? item.KimlikNo.Substring(0, 3) + "*****" + item.KimlikNo.Substring(7,3):"";
                    pdfModel.Add(new PolicePdfModel()
                    {
                        KimlikNo = encryptedKimlikNo,
                        Ad = item.Ad,
                        Soyad = item.Soyad,
                        Uyruk = item.Uyruk,
                        UlkeAd = item.UlkeAd,
                        UzunAd = item.UzunAd,
                        ZeylTip = item.ZeylTip,
                        DogumYeri = item.DogumYeri
                    });
                }
                PdfCreate.CreatePdf(pdfModel);
            }
            catch (Exception e)
            {
                FileLogHelper.LogFile(FilePath.TRYCATCHLOGFILENAME,
                        e.Message.ToString());
            }
        }
    }
}

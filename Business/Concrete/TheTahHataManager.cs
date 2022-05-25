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
    public class TheTahHataManager : ITheTahHataService
    {
        public static List<string> _theTahHataList = new List<string>();
        private const string _fileName = @"THE_TAH_HATA_13052022_LOG.TXT";
        public void ReadData()
        {
            try
            {
                _theTahHataList.AddRange(TextFileConnection<TheTahHata>.GetTextFileData());
                List<TheTahHata> theTahHataDatas = new List<TheTahHata>();
                foreach (string line in _theTahHataList)
                {
                    var brans = line.Substring(0, 2).Trim();
                    var sayacNo = line.Substring(3, 15).Trim();
                    var police = line.Substring(17, 15).Trim();
                    var donem = line.Substring(32, 10).Trim();
                    var borcTipi = line.Substring(42, 5).Trim();
                    var tutar = line.Substring(47, 21).Trim();
                    var adSoyad = line.Substring(68, 50).Trim();
                    var hataKod = line.Substring(118, 15).Trim();

                    switch (brans)
                    {
                        case "Z3":
                            brans = "E";
                            break;
                        case "Z4":
                            brans = "H";
                            break;
                        case "Z5":
                            brans = "K";
                            break;
                        default:
                            hataKod = "geçersiz branş kodu";
                            break;
                    }

                    var theTahHataModel = new TheTahHata()
                    {
                        AdSoyad = adSoyad,
                        HataKodu = hataKod,
                        Tutar = tutar,
                        BorcTipi = borcTipi,
                        Donem = donem,
                        Police = police,
                        SayacNo = sayacNo,
                        Brans = brans
                    };
                    theTahHataDatas.Add(theTahHataModel);
                }
                LogToData(_fileName, theTahHataDatas.Where(x => x.HataKodu != "2").ToList());
            }
            catch (Exception e)
            {
                FileLogHelper.LogFile(FilePath.TRYCATCHLOGFILENAME,
                        e.Message.ToString());
            }
        }

        public void LogToData(string logFileName, List<TheTahHata> logToData)
        {
            try
            {
                foreach (var item in logToData)
                {
                    FileLogHelper.LogFile(logFileName,
                        $"{item.Donem},{item.AdSoyad},{item.Police},{item.Brans}");
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


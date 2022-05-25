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
    public class VkfeManager : IVkfeService
    {
        public static List<string> _theVkfeList = new List<string>();
        private const string _fileName = @"VKFE20220513030052_LOG.TXT";
        public void ReadData()
        {
            try
            {
                _theVkfeList.AddRange(TextFileConnection<VKFE>.GetTextFileData());
                List<VKFE> vkfeDatas = new List<VKFE>();
                foreach (string line in _theVkfeList)
                {
                    var brans = line.Substring(0, 1).Trim();
                    var sayacNo = line.Substring(2, 15).Trim();
                    var police = line.Substring(16, 15).Trim();
                    var donem = line.Substring(31, 10).Trim();
                    var borcTipi = line.Substring(41, 5).Trim();
                    var tutar = line.Substring(46, 21).Trim();
                    var adSoyad = line.Substring(67, 50).Trim();
                    var hataKod = line.Substring(117, 15).Trim();

                    switch (brans)
                    {
                        case "H":
                            break;
                        case "K":
                            break;
                        case "E":
                            break;
                        default:
                            hataKod = "geçersiz branş kodu";
                            break;
                    }

                    var vkfeModel = new VKFE()
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
                    vkfeDatas.Add(vkfeModel);
                }
                LogToData(_fileName, vkfeDatas.Where(x => x.HataKodu != "23").ToList());
            }
            catch (Exception e)
            {
                FileLogHelper.LogFile(FilePath.TRYCATCHLOGFILENAME,
                        e.Message.ToString());
            }
        }
        public void LogToData(string logFileName, List<VKFE> logToData)
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

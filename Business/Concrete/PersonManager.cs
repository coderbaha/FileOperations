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
    public class PersonManager : IPersonService
    {

        public static List<Person> _personList = new List<Person>();

        public void OverThirtyYearsOld()
        {
            try
            {
                _personList.AddRange(ExcelConnection<Person>.GetExcelData());
                int musteriCount = _personList.Where(x => (DateTime.Now.Year - Convert.ToDateTime(x.DogTar).Year) > 30).Count();
                string result = "30 yaşından büyük {0} müşterimiz var.";
                Console.WriteLine(result, musteriCount);
            }
            catch (Exception e)
            {
                FileLogHelper.LogFile(FilePath.TRYCATCHLOGFILENAME,
                        e.Message.ToString());
            }
        }
    }
}

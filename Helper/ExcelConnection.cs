using Entity.Abstract;
using Entity.Concrete;
using Helper.FilePaths;
using Ganss.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class ExcelConnection<T> where T : class, IEntity, new()
    {
        public static List<T> GetExcelData()
        {
            try
            {
                var excelTable = typeof(T).GetCustomAttribute<TableAttribute>();
                var connection = new ExcelMapper(FilePath.EXCELPATH + excelTable.Name);
                var result = connection.Fetch<T>().ToList();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}

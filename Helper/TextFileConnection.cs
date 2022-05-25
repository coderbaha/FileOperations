using Entity.Abstract;
using Helper.FilePaths;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{

    public class TextFileConnection<T> where T : class, IEntity, new()
    {
        public static List<string> GetTextFileData()
        {
            try { 
            var txtTable = typeof(T).GetCustomAttribute<TableAttribute>();
            List<string> lines = new List<string>();
            lines = System.IO.File.ReadAllLines(FilePath.TEXTPATH + txtTable.Name).ToList();
            return lines;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

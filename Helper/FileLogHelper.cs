using Helper.FilePaths;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper
{
    public class FileLogHelper
    {
        public static void LogFile(string filename, string logWrite)
        {
            try { 
            using StreamWriter logFile =
                new(FilePath.TEXTPATH + filename,
                    append: true);
            logFile.WriteLineAsync(logWrite);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

using ICSC.SysUtil.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertExcel.Class
{
    public class SHM
    {
        public static string CurrentAPName = string.Empty;
        public static string CurrentAPPath = string.Empty;
        public static string ExportFileName = "DataLink.cs";
        public static bool ReplaceExistFile = true;

        /// <summary>
        /// Queue for Write System Log
        /// </summary>
        public static SafeQueue<string> QueueWriteSystemLog = new SafeQueue<string>();

        /// <summary>
        /// System Log
        /// </summary>
        //public static LogOperation SystemLog;

        public static bool LOG_LEVEL_ENABLE = true;
    }
}

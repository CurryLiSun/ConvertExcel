using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System;
using System.IO;

using Excel = Microsoft.Office.Interop.Excel;

namespace ConvertExcel.Class
{
    class DataLinkConvertFunction
    {
        public static void ExportDataLinkFile(string sourcePath)
        {
            //ConvertDataLink
            string code = ConvertDataLink(sourcePath);
            // 寫檔
            WriteToFile(code);
        }

        private static string ConvertDataLink(string source)
        {
            //ISheet sheet = workbook.GetSheetAt(3);
            Excel.Application _Excel = new Excel.Application();
            string pFileName = source;

            Excel.Workbook book = null;
            Excel.Worksheet sheet = null;
            Excel.Range range = null;

            book = _Excel.Workbooks.Open(pFileName);//開啟舊檔案
            sheet = (Excel.Worksheet)book.Sheets[3];
            range = sheet.get_Range("A1", "A50");

            foreach (Excel.Range item in range)
            {
                string strData = string.Format("[{0},{1}] = {2}", item.Cells.Column, item.Cells.Row, item.Cells.Text);
                System.Diagnostics.Debug.WriteLine(strData);
            }
            //SHM.QueueWriteSystemLog.Enqueue(sheet.SheetName);
            //System.Diagnostics.Debug.WriteLine(sheet.SheetName);
            book.Close();
            _Excel.Quit();
            return null;
        }

        private static void WriteToFile(string code)
        {
            // 儲存路徑
            string saveFilePath = "C:/Temp/";
        }
    }
}

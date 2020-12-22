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
            XSSFWorkbook workbook = GetWorkbook(sourcePath);
            // 無法正常取得 Workbook 物件
            if (workbook == null)
            {
                return;
            }

            // 活頁簿轉換成對應類別內容
            string code = ConvertDataLink(workbook, sourcePath);

            // 寫檔
            WriteToFile(code);
        }

        private static XSSFWorkbook GetWorkbook(string sourcePath)
        {
            // 判斷路徑下檔案是否存在
            if (!File.Exists(sourcePath))
            {
                SHM.QueueWriteSystemLog.Enqueue("檔案不存在");
                return null;
            }

            try
            {
                using (FileStream fs = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
                {
                    try
                    {
                        return new XSSFWorkbook(fs);
                    }
                    catch (FileNotFoundException ex)
                    {
                        SHM.QueueWriteSystemLog.Enqueue("不是合法的 excel 檔案");
                        return null;
                    }
                }
            }
            catch (Exception e)
            {
                SHM.QueueWriteSystemLog.Enqueue("檔案已被其他應用程式開啟，請先關閉");
                return null;
            }
        }

        private static string ConvertDataLink(XSSFWorkbook workbook, string source)
        {
            //ISheet sheet = workbook.GetSheetAt(3);
            Excel.Application _Excel = null;
            string pFileName = source;

            Excel.Workbook book = null;
            Excel.Worksheet sheet = null;
            Excel.Range range = null;

            book = _Excel.Workbooks.Open(pFileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);//開啟舊檔案
            sheet = (Excel.Worksheet)book.Sheets[1];
            range = sheet.get_Range("A1", "A10");

            foreach (Excel.Range item in range)
            {
                string strData = string.Format("[{0},{1}] = {2}", item.Cells.Column, item.Cells.Row, item.Cells.Text);
                System.Diagnostics.Debug.WriteLine(strData);
            }

            //SHM.QueueWriteSystemLog.Enqueue(sheet.SheetName);
            //System.Diagnostics.Debug.WriteLine(sheet.SheetName);
            return null;
        }

        private static void WriteToFile(string code)
        {
            // 儲存路徑
            string saveFilePath = "C:/Temp/";
        }
    }
}

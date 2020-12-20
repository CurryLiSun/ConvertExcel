using ConvertExcel.Class;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ConvertExcel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OFD_SourcePathFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("===OFD_SourcePathFileDialog_FileOk");
            string sourceFilePath = OFD_SourcePathFileDialog.FileName;
            TB_SourcePath.Text = sourceFilePath;
            //SHM.QueueWriteSystemLog.Enqueue("選擇來源檔路徑 " + sourceFilePath);
        }

        private void BTN_ChoosePath_Click(object sender, EventArgs e)
        {
            OFD_SourcePathFileDialog.ShowDialog();
        }

        private void BTN_ConvertData_Click(object sender, EventArgs e)
        {
            string SourcePath = TB_SourcePath.Text;
            //string DestPath = textBox_DestPath.Text;
            if (String.IsNullOrEmpty(SourcePath))
            {
                SHM.QueueWriteSystemLog.Enqueue("來源檔案路徑為空");
            }
            else
            {
                DataLinkConvertFunction.ExportDataLinkFile(SourcePath);
            }
        }

        public void AddListView(string msg)
        {
            if (this.LV_SystemLog.Items.Count > 300)
            {
                this.LV_SystemLog.Items.Clear();
            }
            this.LV_SystemLog.Items.Insert(0, "[" + DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + "] " + msg);
        }

        private void T_LogTick_Tick(object sender, EventArgs e)
        {
            int msgCount = SHM.QueueWriteSystemLog.Count;
            for (int i = 0; i < msgCount; i++)
            {
                string msg = SHM.QueueWriteSystemLog.Dequeue();
                // 畫面輸出
                AddListView(msg);
                // 寫檔備存
                //SHM.SystemLog.WriteLog(msg, SHM.LOG_LEVEL_ENABLE);
            }
        }
    }
}

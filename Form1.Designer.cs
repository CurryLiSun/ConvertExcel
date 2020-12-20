
namespace ConvertExcel
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.OFD_SourcePathFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.BTN_ChoosePath = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.TB_SourcePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_ConvertData = new System.Windows.Forms.Button();
            this.LV_SystemLog = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.T_LogTick = new System.Windows.Forms.Timer(this.components);
            this.Record_Idx = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // OFD_SourcePathFileDialog
            // 
            this.OFD_SourcePathFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OFD_SourcePathFileDialog_FileOk);
            // 
            // BTN_ChoosePath
            // 
            this.BTN_ChoosePath.Location = new System.Drawing.Point(584, 31);
            this.BTN_ChoosePath.Name = "BTN_ChoosePath";
            this.BTN_ChoosePath.Size = new System.Drawing.Size(125, 45);
            this.BTN_ChoosePath.TabIndex = 0;
            this.BTN_ChoosePath.Text = "選擇路徑";
            this.BTN_ChoosePath.UseVisualStyleBackColor = true;
            this.BTN_ChoosePath.Click += new System.EventHandler(this.BTN_ChoosePath_Click);
            // 
            // TB_SourcePath
            // 
            this.TB_SourcePath.Location = new System.Drawing.Point(169, 40);
            this.TB_SourcePath.Name = "TB_SourcePath";
            this.TB_SourcePath.Size = new System.Drawing.Size(409, 25);
            this.TB_SourcePath.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "來源檔案路徑";
            // 
            // BTN_ConvertData
            // 
            this.BTN_ConvertData.Location = new System.Drawing.Point(69, 105);
            this.BTN_ConvertData.Name = "BTN_ConvertData";
            this.BTN_ConvertData.Size = new System.Drawing.Size(75, 31);
            this.BTN_ConvertData.TabIndex = 3;
            this.BTN_ConvertData.Text = "轉換";
            this.BTN_ConvertData.UseVisualStyleBackColor = true;
            this.BTN_ConvertData.Click += new System.EventHandler(this.BTN_ConvertData_Click);
            // 
            // LV_SystemLog
            // 
            this.LV_SystemLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Record_Idx});
            this.LV_SystemLog.HideSelection = false;
            this.LV_SystemLog.Location = new System.Drawing.Point(69, 240);
            this.LV_SystemLog.Name = "LV_SystemLog";
            this.LV_SystemLog.Size = new System.Drawing.Size(508, 161);
            this.LV_SystemLog.TabIndex = 4;
            this.LV_SystemLog.UseCompatibleStateImageBehavior = false;
            this.LV_SystemLog.View = System.Windows.Forms.View.Details;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "系統顯示";
            // 
            // T_LogTick
            // 
            this.T_LogTick.Enabled = true;
            this.T_LogTick.Interval = 500;
            this.T_LogTick.Tick += new System.EventHandler(this.T_LogTick_Tick);
            // 
            // Record_Idx
            // 
            this.Record_Idx.Text = "紀錄";
            this.Record_Idx.Width = 500;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LV_SystemLog);
            this.Controls.Add(this.BTN_ConvertData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_SourcePath);
            this.Controls.Add(this.BTN_ChoosePath);
            this.Name = "Form1";
            this.Text = "ExcelConvert";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OFD_SourcePathFileDialog;
        private System.Windows.Forms.Button BTN_ChoosePath;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox TB_SourcePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_ConvertData;
        private System.Windows.Forms.ListView LV_SystemLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer T_LogTick;
        private System.Windows.Forms.ColumnHeader Record_Idx;
    }
}


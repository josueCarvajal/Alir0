namespace ExcelAddIn.DataBase
{
    partial class ProgressBar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.progressBarMain = new System.Windows.Forms.ProgressBar();
            this.backgroundWorkerMain = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // progressBarMain
            // 
            this.progressBarMain.Location = new System.Drawing.Point(12, 35);
            this.progressBarMain.Name = "progressBarMain";
            this.progressBarMain.Size = new System.Drawing.Size(223, 37);
            this.progressBarMain.TabIndex = 0;
            // 
            // backgroundWorkerMain
            // 
            this.backgroundWorkerMain.WorkerReportsProgress = true;
            this.backgroundWorkerMain.WorkerSupportsCancellation = true;
            this.backgroundWorkerMain.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerMain_DoWork);
            this.backgroundWorkerMain.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorkerMain_ProgressChanged);
            this.backgroundWorkerMain.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorkerMain_RunWorkerCompleted);
            // 
            // ProgressBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 108);
            this.Controls.Add(this.progressBarMain);
            this.Name = "ProgressBar";
            this.Text = "Loading...";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarMain;
        private System.ComponentModel.BackgroundWorker backgroundWorkerMain;
    }
}
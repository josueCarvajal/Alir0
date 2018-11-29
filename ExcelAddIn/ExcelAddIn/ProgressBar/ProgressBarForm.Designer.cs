namespace ExcelAddIn.ProgressBar
{
    partial class ProgressBarForm
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
            this.progressBarmain = new System.Windows.Forms.ProgressBar();
            this.ProgressBarFormBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.BGWQueryToDataBase = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // progressBarmain
            // 
            this.progressBarmain.Location = new System.Drawing.Point(12, 12);
            this.progressBarmain.Name = "progressBarmain";
            this.progressBarmain.Size = new System.Drawing.Size(352, 24);
            this.progressBarmain.TabIndex = 0;
            // 
            // ProgressBarFormBackgroundWorker
            // 
            this.ProgressBarFormBackgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.ProgressBarFormBackgroundWorker_DoWork);
            this.ProgressBarFormBackgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ProgressBarFormBackgroundWorker_RunWorkerCompleted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please wait";
            // 
            // BGWQueryToDataBase
            // 
            this.BGWQueryToDataBase.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWQueryToDataBase_DoWork);
            this.BGWQueryToDataBase.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGWQueryToDataBase_RunWorkerCompleted);
            // 
            // ProgressBarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 79);
            this.ControlBox = false;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBarmain);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgressBarForm";
            this.ShowIcon = false;
            this.Text = "Loading...";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.ProgressBar progressBarmain;
        public System.ComponentModel.BackgroundWorker ProgressBarFormBackgroundWorker;
        private System.Windows.Forms.Label label1;
        public System.ComponentModel.BackgroundWorker BGWQueryToDataBase;
    }
}
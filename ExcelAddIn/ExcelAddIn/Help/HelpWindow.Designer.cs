namespace ExcelAddIn.Help
{
    partial class HelpWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpWindow));
            this.btnFirstSteps = new System.Windows.Forms.Button();
            this.btnDatabaseModule = new System.Windows.Forms.Button();
            this.btnTimeSeries = new System.Windows.Forms.Button();
            this.btnCommonErrors = new System.Windows.Forms.Button();
            this.PdfViewer = new AxAcroPDFLib.AxAcroPDF();
            ((System.ComponentModel.ISupportInitialize)(this.PdfViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFirstSteps
            // 
            this.btnFirstSteps.Location = new System.Drawing.Point(12, 25);
            this.btnFirstSteps.Name = "btnFirstSteps";
            this.btnFirstSteps.Size = new System.Drawing.Size(113, 23);
            this.btnFirstSteps.TabIndex = 0;
            this.btnFirstSteps.Text = "First steps";
            this.btnFirstSteps.UseVisualStyleBackColor = true;
            this.btnFirstSteps.Click += new System.EventHandler(this.btnFirstSteps_Click);
            // 
            // btnDatabaseModule
            // 
            this.btnDatabaseModule.Location = new System.Drawing.Point(12, 54);
            this.btnDatabaseModule.Name = "btnDatabaseModule";
            this.btnDatabaseModule.Size = new System.Drawing.Size(113, 23);
            this.btnDatabaseModule.TabIndex = 1;
            this.btnDatabaseModule.Text = "Database module";
            this.btnDatabaseModule.UseVisualStyleBackColor = true;
            this.btnDatabaseModule.Click += new System.EventHandler(this.btnDatabaseModule_Click);
            // 
            // btnTimeSeries
            // 
            this.btnTimeSeries.Location = new System.Drawing.Point(12, 83);
            this.btnTimeSeries.Name = "btnTimeSeries";
            this.btnTimeSeries.Size = new System.Drawing.Size(113, 23);
            this.btnTimeSeries.TabIndex = 2;
            this.btnTimeSeries.Text = "Time series module";
            this.btnTimeSeries.UseVisualStyleBackColor = true;
            this.btnTimeSeries.Click += new System.EventHandler(this.btnTimeSeries_Click);
            // 
            // btnCommonErrors
            // 
            this.btnCommonErrors.Location = new System.Drawing.Point(12, 112);
            this.btnCommonErrors.Name = "btnCommonErrors";
            this.btnCommonErrors.Size = new System.Drawing.Size(113, 23);
            this.btnCommonErrors.TabIndex = 3;
            this.btnCommonErrors.Text = "Common errors";
            this.btnCommonErrors.UseVisualStyleBackColor = true;
            this.btnCommonErrors.Click += new System.EventHandler(this.btnCommonErrors_Click);
            // 
            // PdfViewer
            // 
            this.PdfViewer.Enabled = true;
            this.PdfViewer.Location = new System.Drawing.Point(147, 38);
            this.PdfViewer.Name = "PdfViewer";
            this.PdfViewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("PdfViewer.OcxState")));
            this.PdfViewer.Size = new System.Drawing.Size(832, 503);
            this.PdfViewer.TabIndex = 4;
            // 
            // HelpWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(991, 553);
            this.Controls.Add(this.PdfViewer);
            this.Controls.Add(this.btnCommonErrors);
            this.Controls.Add(this.btnTimeSeries);
            this.Controls.Add(this.btnDatabaseModule);
            this.Controls.Add(this.btnFirstSteps);
            this.Name = "HelpWindow";
            this.ShowIcon = false;
            this.Text = "HelpWindow";
            ((System.ComponentModel.ISupportInitialize)(this.PdfViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFirstSteps;
        private System.Windows.Forms.Button btnDatabaseModule;
        private System.Windows.Forms.Button btnTimeSeries;
        private System.Windows.Forms.Button btnCommonErrors;
        private AxAcroPDFLib.AxAcroPDF PdfViewer;
    }
}
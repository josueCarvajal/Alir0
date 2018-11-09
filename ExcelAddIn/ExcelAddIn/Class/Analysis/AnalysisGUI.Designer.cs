namespace ExcelAddIn.Class
{
    partial class AnalysisGUI
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
            this.commonBox = new System.Windows.Forms.GroupBox();
            this.cb_AnalysisChooser = new System.Windows.Forms.ComboBox();
            this.lbl_chooseAnalysis = new System.Windows.Forms.Label();
            this.lbl_description = new System.Windows.Forms.Label();
            this.btn_go = new System.Windows.Forms.Button();
            this.commonBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // commonBox
            // 
            this.commonBox.Controls.Add(this.cb_AnalysisChooser);
            this.commonBox.Controls.Add(this.lbl_chooseAnalysis);
            this.commonBox.Controls.Add(this.lbl_description);
            this.commonBox.Location = new System.Drawing.Point(12, 12);
            this.commonBox.Name = "commonBox";
            this.commonBox.Size = new System.Drawing.Size(436, 130);
            this.commonBox.TabIndex = 0;
            this.commonBox.TabStop = false;
            this.commonBox.Text = "Choose your analysis";
            // 
            // cb_AnalysisChooser
            // 
            this.cb_AnalysisChooser.FormattingEnabled = true;
            this.cb_AnalysisChooser.Location = new System.Drawing.Point(134, 81);
            this.cb_AnalysisChooser.Name = "cb_AnalysisChooser";
            this.cb_AnalysisChooser.Size = new System.Drawing.Size(281, 21);
            this.cb_AnalysisChooser.TabIndex = 2;
            // 
            // lbl_chooseAnalysis
            // 
            this.lbl_chooseAnalysis.AutoSize = true;
            this.lbl_chooseAnalysis.Location = new System.Drawing.Point(27, 84);
            this.lbl_chooseAnalysis.Name = "lbl_chooseAnalysis";
            this.lbl_chooseAnalysis.Size = new System.Drawing.Size(101, 13);
            this.lbl_chooseAnalysis.TabIndex = 1;
            this.lbl_chooseAnalysis.Text = "Choose an analysis:";
            // 
            // lbl_description
            // 
            this.lbl_description.AutoSize = true;
            this.lbl_description.Location = new System.Drawing.Point(27, 37);
            this.lbl_description.Name = "lbl_description";
            this.lbl_description.Size = new System.Drawing.Size(178, 13);
            this.lbl_description.TabIndex = 0;
            this.lbl_description.Text = "SOME DESCRIPTION TEXT HERE";
            // 
            // btn_go
            // 
            this.btn_go.Location = new System.Drawing.Point(377, 148);
            this.btn_go.Name = "btn_go";
            this.btn_go.Size = new System.Drawing.Size(71, 25);
            this.btn_go.TabIndex = 5;
            this.btn_go.Text = "Go";
            this.btn_go.UseVisualStyleBackColor = true;
            this.btn_go.Click += new System.EventHandler(this.btn_solve_Click);
            // 
            // AnalysisGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 181);
            this.Controls.Add(this.btn_go);
            this.Controls.Add(this.commonBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AnalysisGUI";
            this.ShowIcon = false;
            this.Text = "AnalysisGUI";
            this.Load += new System.EventHandler(this.AnalysisGUI_Load);
            this.commonBox.ResumeLayout(false);
            this.commonBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox commonBox;
        private System.Windows.Forms.Label lbl_description;
        private System.Windows.Forms.ComboBox cb_AnalysisChooser;
        private System.Windows.Forms.Label lbl_chooseAnalysis;
        private System.Windows.Forms.Button btn_go;
    }
}
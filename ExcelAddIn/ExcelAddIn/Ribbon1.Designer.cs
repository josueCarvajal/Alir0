namespace ExcelAddIn
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tab1 = this.Factory.CreateRibbonTab();
            this.RiALIRO = this.Factory.CreateRibbonGroup();
            this.btnDataBase = this.Factory.CreateRibbonButton();
            this.button1 = this.Factory.CreateRibbonButton();
            this.mCharts = this.Factory.CreateRibbonMenu();
            this.btnHistogram = this.Factory.CreateRibbonButton();
            this.btnColumn = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.RiALIRO.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Groups.Add(this.RiALIRO);
            this.tab1.Label = "Aliro";
            this.tab1.Name = "tab1";
            // 
            // RiALIRO
            // 
            this.RiALIRO.Items.Add(this.btnDataBase);
            this.RiALIRO.Items.Add(this.button1);
            this.RiALIRO.Items.Add(this.mCharts);
            this.RiALIRO.Label = "ALIRO";
            this.RiALIRO.Name = "RiALIRO";
            // 
            // btnDataBase
            // 
            this.btnDataBase.Label = "SQL Query";
            this.btnDataBase.Name = "btnDataBase";
            // 
            // button1
            // 
            this.button1.Label = "button1";
            this.button1.Name = "button1";
            this.button1.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.button1_Click);
            // 
            // mCharts
            // 
            this.mCharts.Items.Add(this.btnColumn);
            this.mCharts.Items.Add(this.btnHistogram);
            this.mCharts.Label = "Charts";
            this.mCharts.Name = "mCharts";
            // 
            // btnHistogram
            // 
            this.btnHistogram.Label = "Histogram";
            this.btnHistogram.Name = "btnHistogram";
            this.btnHistogram.ShowImage = true;
            this.btnHistogram.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnHistogram_Click);
            // 
            // btnColumn
            // 
            this.btnColumn.Label = "Column";
            this.btnColumn.Name = "btnColumn";
            this.btnColumn.ShowImage = true;
            this.btnColumn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnColumn_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.RiALIRO.ResumeLayout(false);
            this.RiALIRO.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup RiALIRO;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnDataBase;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonMenu mCharts;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnHistogram;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnColumn;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}

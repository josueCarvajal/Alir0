namespace ExcelAddIn
{
    partial class MunuBar : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public MunuBar()
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
            this.btnPackages = this.Factory.CreateRibbonButton();
            this.btn_faqs = this.Factory.CreateRibbonButton();
            this.TimeSeriesGroup = this.Factory.CreateRibbonGroup();
            this.TimeSeriesBtn = this.Factory.CreateRibbonButton();
            this.btnHoltWinters = this.Factory.CreateRibbonButton();
            this.btnGarch = this.Factory.CreateRibbonButton();
            this.btnArima = this.Factory.CreateRibbonButton();
            this.ParametricGroup = this.Factory.CreateRibbonGroup();
            this.RandomForestBtn = this.Factory.CreateRibbonButton();
            this.DecisionTreesButton = this.Factory.CreateRibbonButton();
            this.ClusterAnalysisBtn = this.Factory.CreateRibbonButton();
            this.DiscriminantAnalysisBtn = this.Factory.CreateRibbonButton();
            this.BinaryVariableBtn = this.Factory.CreateRibbonButton();
            this.NonParametricGroup = this.Factory.CreateRibbonGroup();
            this.CrossSectionalBtn = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.RiALIRO.SuspendLayout();
            this.TimeSeriesGroup.SuspendLayout();
            this.ParametricGroup.SuspendLayout();
            this.NonParametricGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.Groups.Add(this.RiALIRO);
            this.tab1.Groups.Add(this.TimeSeriesGroup);
            this.tab1.Groups.Add(this.ParametricGroup);
            this.tab1.Groups.Add(this.NonParametricGroup);
            this.tab1.Label = "Aliro";
            this.tab1.Name = "tab1";
            // 
            // RiALIRO
            // 
            this.RiALIRO.Items.Add(this.btnDataBase);
            this.RiALIRO.Items.Add(this.btnPackages);
            this.RiALIRO.Items.Add(this.btn_faqs);
            this.RiALIRO.Label = "ALIRO";
            this.RiALIRO.Name = "RiALIRO";
            // 
            // btnDataBase
            // 
            this.btnDataBase.Label = "Import SQL data";
            this.btnDataBase.Name = "btnDataBase";
            this.btnDataBase.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnDataBase_Click);
            // 
            // btnPackages
            // 
            this.btnPackages.Label = "Install Packages";
            this.btnPackages.Name = "btnPackages";
            this.btnPackages.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnPackages_Click);
            // 
            // btn_faqs
            // 
            this.btn_faqs.Label = "FAQs";
            this.btn_faqs.Name = "btn_faqs";
            this.btn_faqs.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_faqs_Click);
            // 
            // TimeSeriesGroup
            // 
            this.TimeSeriesGroup.Items.Add(this.TimeSeriesBtn);
            this.TimeSeriesGroup.Items.Add(this.btnHoltWinters);
            this.TimeSeriesGroup.Items.Add(this.btnGarch);
            this.TimeSeriesGroup.Items.Add(this.btnArima);
            this.TimeSeriesGroup.Label = "Time Series Analysis";
            this.TimeSeriesGroup.Name = "TimeSeriesGroup";
            // 
            // TimeSeriesBtn
            // 
            this.TimeSeriesBtn.Label = "Time Series";
            this.TimeSeriesBtn.Name = "TimeSeriesBtn";
            this.TimeSeriesBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.TimeSeriesBtn_Click);
            // 
            // btnHoltWinters
            // 
            this.btnHoltWinters.Label = "Holt Winters";
            this.btnHoltWinters.Name = "btnHoltWinters";
            this.btnHoltWinters.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnHoltWinters_Click);
            // 
            // btnGarch
            // 
            this.btnGarch.Label = "Garch";
            this.btnGarch.Name = "btnGarch";
            this.btnGarch.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnGarch_Click);
            // 
            // btnArima
            // 
            this.btnArima.Label = "Arima";
            this.btnArima.Name = "btnArima";
            this.btnArima.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnArima_Click);
            // 
            // ParametricGroup
            // 
            this.ParametricGroup.Items.Add(this.RandomForestBtn);
            this.ParametricGroup.Items.Add(this.DecisionTreesButton);
            this.ParametricGroup.Items.Add(this.ClusterAnalysisBtn);
            this.ParametricGroup.Items.Add(this.DiscriminantAnalysisBtn);
            this.ParametricGroup.Items.Add(this.BinaryVariableBtn);
            this.ParametricGroup.Label = "Parametric Analysis";
            this.ParametricGroup.Name = "ParametricGroup";
            // 
            // RandomForestBtn
            // 
            this.RandomForestBtn.Label = "Random Forest";
            this.RandomForestBtn.Name = "RandomForestBtn";
            this.RandomForestBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.RandomForestBtn_Click);
            // 
            // DecisionTreesButton
            // 
            this.DecisionTreesButton.Enabled = false;
            this.DecisionTreesButton.Label = "Decision trees";
            this.DecisionTreesButton.Name = "DecisionTreesButton";
            this.DecisionTreesButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.DecisionTreesButton_Click);
            // 
            // ClusterAnalysisBtn
            // 
            this.ClusterAnalysisBtn.Enabled = false;
            this.ClusterAnalysisBtn.Label = "Cluster Analysis";
            this.ClusterAnalysisBtn.Name = "ClusterAnalysisBtn";
            this.ClusterAnalysisBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.ClusterAnalysisBtn_Click);
            // 
            // DiscriminantAnalysisBtn
            // 
            this.DiscriminantAnalysisBtn.Enabled = false;
            this.DiscriminantAnalysisBtn.Label = "Discriminant analysis";
            this.DiscriminantAnalysisBtn.Name = "DiscriminantAnalysisBtn";
            this.DiscriminantAnalysisBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.DiscriminantAnalysisBtn_Click);
            // 
            // BinaryVariableBtn
            // 
            this.BinaryVariableBtn.Enabled = false;
            this.BinaryVariableBtn.Label = "Binary variable models";
            this.BinaryVariableBtn.Name = "BinaryVariableBtn";
            this.BinaryVariableBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BinaryVariableBtn_Click);
            // 
            // NonParametricGroup
            // 
            this.NonParametricGroup.Items.Add(this.CrossSectionalBtn);
            this.NonParametricGroup.Label = "Nonparametric Analysis";
            this.NonParametricGroup.Name = "NonParametricGroup";
            // 
            // CrossSectionalBtn
            // 
            this.CrossSectionalBtn.Enabled = false;
            this.CrossSectionalBtn.Label = "Cross Sectional";
            this.CrossSectionalBtn.Name = "CrossSectionalBtn";
            this.CrossSectionalBtn.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.CrossSectionalBtn_Click);
            // 
            // MunuBar
            // 
            this.Name = "MunuBar";
            this.RibbonType = "Microsoft.Excel.Workbook";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.RiALIRO.ResumeLayout(false);
            this.RiALIRO.PerformLayout();
            this.TimeSeriesGroup.ResumeLayout(false);
            this.TimeSeriesGroup.PerformLayout();
            this.ParametricGroup.ResumeLayout(false);
            this.ParametricGroup.PerformLayout();
            this.NonParametricGroup.ResumeLayout(false);
            this.NonParametricGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup RiALIRO;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnDataBase;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnPackages;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup TimeSeriesGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton TimeSeriesBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton RandomForestBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnHoltWinters;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnGarch;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnArima;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup ParametricGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton DecisionTreesButton;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton ClusterAnalysisBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton DiscriminantAnalysisBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton BinaryVariableBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup NonParametricGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton CrossSectionalBtn;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_faqs;
    }

    partial class ThisRibbonCollection
    {
        internal MunuBar Ribbon1
        {
            get { return this.GetRibbon<MunuBar>(); }
        }
    }
}

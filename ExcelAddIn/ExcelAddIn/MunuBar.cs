using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Tools.Ribbon;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Windows.Forms;

namespace ExcelAddIn
{
    public partial class MunuBar
    {
        int count = 0;
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }
        private void btnPackages_Click(object sender, RibbonControlEventArgs e)
        {
            Class.BertCalls Bert = new Class.BertCalls();
            Bert.bertInstallPackages();
        }

        private void btnHistogram_Click(object sender, RibbonControlEventArgs e)
        {
            Class.BertCalls bert = new Class.BertCalls();
        }

        private void btnColumn_Click(object sender, RibbonControlEventArgs e)
        {
            count = count + 1;
            Excel.Range selection = Globals.ThisAddIn.Application.Selection as Excel.Range;

            Worksheet worksheet = Globals.Factory.GetVstoObject(Globals.ThisAddIn.Application.ActiveWorkbook.ActiveSheet);

            Chart chart = worksheet.Controls.AddChart(selection, "employees" + count);
            chart.ChartType = Microsoft.Office.Interop.Excel.XlChartType.xl3DColumn;
            chart.SetSourceData(selection);
        }

        private void btnDataBase_Click(object sender, RibbonControlEventArgs e)
        {
            DataBase.scfc window = new DataBase.scfc();
        }

        private void TimeSeriesBtn_Click(object sender, RibbonControlEventArgs e)
        {
            Class.Analysis.TimeSeries.TimeSeries_Standard analysis = new Class.Analysis.TimeSeries.TimeSeries_Standard();
            DefaultLayout(analysis.getTitle(), analysis.getDescription(), analysis.getAnalysis(),analysis.getNameOfVectors(),analysis.getNumberOfVectors(),analysis.getFunctionName() );
        }

        private void btnHoltWinters_Click(object sender, RibbonControlEventArgs e)
        {
            Class.Analysis.TimeSeries.TimeSeries_HoltWinters analysis = new Class.Analysis.TimeSeries.TimeSeries_HoltWinters();
            DefaultLayout(analysis.getTitle(), analysis.getDescription(), analysis.getAnalysis(), analysis.getNameOfVectors(), analysis.getNumberOfVectors(), analysis.getFunctionName());
        }

        private void btnArima_Click(object sender, RibbonControlEventArgs e)
        {
            Class.Analysis.TimeSeries.TimeSeries_Arima analysis = new Class.Analysis.TimeSeries.TimeSeries_Arima();
            DefaultLayout(analysis.getTitle(), analysis.getDescription(), analysis.getAnalysis(), analysis.getNameOfVectors(), analysis.getNumberOfVectors(), analysis.getFunctionName());
        }

        private void btnGarch_Click(object sender, RibbonControlEventArgs e)
        {
            Class.Analysis.TimeSeries.TimeSeries_Garch analysis = new Class.Analysis.TimeSeries.TimeSeries_Garch();
            DefaultLayout(analysis.getTitle(), analysis.getDescription(), analysis.getAnalysis(), analysis.getNameOfVectors(), analysis.getNumberOfVectors(), analysis.getFunctionName());
        }

        private void RandomForestBtn_Click(object sender, RibbonControlEventArgs e)
        {
            Class.Analysis.ParametricAnalysis.RandomForest analysis = new Class.Analysis.ParametricAnalysis.RandomForest();
            DefaultLayout(analysis.getTitle(), analysis.getDescription(), analysis.getAnalysis(), analysis.getNameOfVectors(), analysis.getNumberOfVectors(), analysis.getFunctionName());
        }

        private void DecisionTreesButton_Click(object sender, RibbonControlEventArgs e)
        {
            Class.Analysis.ParametricAnalysis.DecisionTrees analysis = new Class.Analysis.ParametricAnalysis.DecisionTrees();
            DefaultLayout(analysis.getTitle(), analysis.getDescription(), analysis.getAnalysis(), analysis.getNameOfVectors(), analysis.getNumberOfVectors(), analysis.getFunctionName());
        }

        private void ClusterAnalysisBtn_Click(object sender, RibbonControlEventArgs e)
        {
            Class.Analysis.ParametricAnalysis.ClusterAnalysis analysis = new Class.Analysis.ParametricAnalysis.ClusterAnalysis();
            DefaultLayout(analysis.getTitle(), analysis.getDescription(), analysis.getAnalysis(), analysis.getNameOfVectors(), analysis.getNumberOfVectors(), analysis.getFunctionName());
        }

        private void DiscriminantAnalysisBtn_Click(object sender, RibbonControlEventArgs e)
        {
            Class.Analysis.ParametricAnalysis.DiscriminantAnalysis analysis = new Class.Analysis.ParametricAnalysis.DiscriminantAnalysis();
            DefaultLayout(analysis.getTitle(), analysis.getDescription(), analysis.getAnalysis(), analysis.getNameOfVectors(), analysis.getNumberOfVectors(), analysis.getFunctionName());
        }

        private void BinaryVariableBtn_Click(object sender, RibbonControlEventArgs e)
        {
            Class.Analysis.ParametricAnalysis.BinaryVariableModels analysis = new Class.Analysis.ParametricAnalysis.BinaryVariableModels();
            DefaultLayout(analysis.getTitle(), analysis.getDescription(), analysis.getAnalysis(), analysis.getNameOfVectors(), analysis.getNumberOfVectors(), analysis.getFunctionName());
        }

        private void CrossSectionalBtn_Click(object sender, RibbonControlEventArgs e)
        {
            Class.Analysis.NonparametricAnalysis.CrossSectional analysis = new Class.Analysis.NonparametricAnalysis.CrossSectional();
            DefaultLayout(analysis.getTitle(), analysis.getDescription(), analysis.getAnalysis(), analysis.getNameOfVectors(), analysis.getNumberOfVectors(), analysis.getFunctionName());
        }

        private void DefaultLayout(string title, string description, string[] analysis, string[,] numberOfVectors, string[,] nameOfVectors, string[,] functionName)
        {
            Class.AnalysisGUI analysisWindow = new Class.AnalysisGUI(title, description, analysis, numberOfVectors, nameOfVectors, functionName);
        }

        private void btn_faqs_Click(object sender, RibbonControlEventArgs e)
        {
            Help.HelpWindow helpWindow = new Help.HelpWindow();
           
        }
    }
}

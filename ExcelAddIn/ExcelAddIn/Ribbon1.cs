using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Tools.Ribbon;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
namespace ExcelAddIn
{
    public partial class Ribbon1
    {
        int count = 0;

        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void button1_Click(object sender, RibbonControlEventArgs e)
        {
            Class.BertCalls bert = new Class.BertCalls();
            bert.Sumar();
        }

        private void btnHistogram_Click(object sender, RibbonControlEventArgs e)
        {
            Class.BertCalls bert = new Class.BertCalls();
            bert.Histogram();
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
    }
}

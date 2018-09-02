using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Windows.Forms;


namespace ExcelAddIn
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        void InternalStartup()
        {
        }

        public void BertCall(string functionName, String dataRange)
        {
            if(dataRange.Equals("00:00"))
            {
                MessageBox.Show("Blank cells were found, pleace fill it and try again");
            }
            else
            {
                double resultado = Application.Run("BERT.Call", functionName, getCurrentWorkSheet().Range[dataRange]);
                MessageBox.Show(resultado.ToString());
            }
        }

        private Worksheet getCurrentWorkSheet()
        {
            Worksheet currentWorksheet = Globals.Factory.GetVstoObject(
            this.Application.ActiveWorkbook.Worksheets[1]);
            return currentWorksheet;
        }
    }
}

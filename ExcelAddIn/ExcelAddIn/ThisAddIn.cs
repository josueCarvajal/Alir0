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
                MessageBox.Show("Please check your empty cells");
            }
            else
            {
                object resultado = Application.Run("BERT.Call", functionName, getCurrentActiveSheet().Range[dataRange]);
                MessageBox.Show(resultado.ToString());
            }
        }

        private Excel.Worksheet getCurrentActiveSheet()
        {
            Excel.Workbook currentWorkBook = this.Application.ActiveWorkbook;
            return currentWorkBook.ActiveSheet;
        }
        public void FillCellsFromDataBase(List<String> DataBaseQuery, String columnindex) {
                    
            Excel.Worksheet currentWorkBook = getCurrentActiveSheet();
            
            for (int i = 0; i < DataBaseQuery.Count; i++)
            {
                currentWorkBook.Range[columnindex + (i + 1)].Value2 = DataBaseQuery[i];
            }
            
            
        }
        
    }
}

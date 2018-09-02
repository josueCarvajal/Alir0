using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Windows.Forms;

namespace ExcelAddIn.Class
{
    class BertCalls
    {
        public string getRange()//need to validate the non data cells
        {
            Excel.Range selectedRange = Globals.ThisAddIn.Application.Selection;
            return selectedRange.Address.ToString();
        }

        public void bertCalls(string functionName)
        {
            Globals.ThisAddIn.BertCall(functionName, getRange());
        }

        public void Sumar()
        {
            bertCalls("sum");
        }

    }
}

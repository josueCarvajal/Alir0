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
        Validations validate = new Validations();

        public void bertCalls(string functionName)
        {
            Globals.ThisAddIn.BertCall(functionName, validate.getRange());
        }

        public void Sumar() //this method is just used here to TEST. Each function will be called from the respective class
        {
            Excel.Range selectedRange = Globals.ThisAddIn.Application.Selection;
            bertCalls("sum");
        }

    }
}

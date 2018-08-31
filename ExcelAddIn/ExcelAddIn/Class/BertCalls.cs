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
    public void Sumar()
        {
            Excel.Range selection = Globals.ThisAddIn.Application.Selection as Excel.Range;//esto esta en prueba
            Globals.ThisAddIn.BertCall("sum", "A1:A5");
        }

    }
}

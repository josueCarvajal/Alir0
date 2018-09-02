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
    class Validations
    {
        public bool hasEmptyCells(Excel.Range selectedRange)
        {
            double blankCells = Globals.ThisAddIn.Application.WorksheetFunction.CountBlank(selectedRange);
            if (blankCells == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string getRange()
        {
            Excel.Range selectedRange = Globals.ThisAddIn.Application.Selection;

            if(hasEmptyCells(selectedRange))
            {
                return "00:00"; //message validated at ThisAddIn.cs.
            }
            else
            {
                return selectedRange.Address.ToString();
            }



        }

        public double getFilledCells(Excel.Range selectedRange)
        {
            return Globals.ThisAddIn.Application.WorksheetFunction.CountA(selectedRange);
        }
    }
}

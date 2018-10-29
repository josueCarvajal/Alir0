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
        public bool allowEmptyCells(Excel.Range selectedRange)
        {
            double blankCells = Globals.ThisAddIn.Application.WorksheetFunction.CountBlank(selectedRange);
            if (blankCells != 0)
            {
                DialogResult dialogResult = MessageBox.Show("Blank cells were found. \nDo you want to ignore them?", "Warning", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes) //I want to ignore them. NA.OMIT in R is used
                {
                    return true;
                }
                else if (dialogResult == DialogResult.No) //Nothing to do
                {
                    return false;
                }
            }
         return true;
        }

        public string getRange()
        {
            Excel.Range selectedRange = Globals.ThisAddIn.Application.Selection;

            if(allowEmptyCells(selectedRange))
            {
                return selectedRange.Address.ToString(); 
            }
            else
            {
                return "00:00"; //message validated at ThisAddIn.cs.
            }
        }

        public double getFilledCells(Excel.Range selectedRange)
        {
            return Globals.ThisAddIn.Application.WorksheetFunction.CountA(selectedRange);
        }
    }
}

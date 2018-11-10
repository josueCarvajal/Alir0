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
        public string getRange()
        {
            Excel.Range selectedRange = Globals.ThisAddIn.Application.Selection;
            
          return selectedRange.Address.ToString(); 
        }

        public double getFilledCells(Excel.Range selectedRange)
        {
            return Globals.ThisAddIn.Application.WorksheetFunction.CountA(selectedRange);
        }

        public int getNumberOfVectors(string nameOfAnalysis, String[,] vectors)
        {
            for(int i=0; i<10;i++)
            {
                string analysisName = vectors[i,0];
                if (analysisName.Equals(nameOfAnalysis))
                {
                    int number = Convert.ToInt16(vectors[i, 1]);
                    return number;
                }
            }
            return 0;
        }
        public string getFunctionName(string nameOfAnalysis,string[,] vectors)
        {
            for (int i = 0; i < 10; i++)
            {
                string analysisName = vectors[i, 0];
                if (analysisName.Equals(nameOfAnalysis))
                {
                    string functionName= vectors[i, 1];
                    return functionName;
                }
            }
            return "";
        }


        //not programed yet
        public string getNameOfVectors(string nameOfAnalysis, String[,] vectors)
        {
            for (int i = 0; i < 10; i++)
            {
                string analysisName = vectors[i, 0];
                if (analysisName.Equals(nameOfAnalysis))
                {
                    int number = Convert.ToInt16(vectors[i, 1]);
                    return "";
                }
            }
            return "";
        }



    }

}

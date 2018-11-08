using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Windows.Forms;

namespace ExcelAddIn.Class.Analysis.TimeSeries
{
    class TimeSeries_HoltWinters
    {
        public string getTitle()
        {
            return "Holt Winters Analysis";
        }

        public string getDescription()
        {
            return "A set of analysis with the respective graphs";
        }
        public string[] getAnalysis()
        {
            return new string[] {
                "No trend level or seasonal components",
                "With trend level",
                "With trend level and seasonal components."
            };
        }
        public string[,] getNumberOfVectors()//returns the number vectors needed for each analysis
        {
            return new string[,]
            {
               {  "No trend level or seasonal components","1"},
               {  "With trend level","1"},
               {"With trend level and seasonal components.","1"}
            };
        }
        public string[,] getNameOfVectors()//returns the name of vectors needed for each analysis
        {
            return new string[,]
            {
               {"No trend level or seasonal components","Vector A"},
               {"With trend level","Vector B"},
               {"With trend level and seasonal components.","B"}
            };
        }
        public string[,] getFunctionName()
        {
            return null;
        }
    }
}

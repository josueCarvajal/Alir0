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
    class TimeSeries_Arima
    {
        public string getTitle()
        {
            return "Arima Analysis";
        }

        public string getDescription()
        {
            return "A set of analysis with the respective graphs";
        }
        public string[] getAnalysis()
        {
            return new string[] {
                "No seasonal components",
                "With seasonal components"
            };
        }
        public string[,] getNumberOfVectors()//returns the number vectors needed for each analysis
        {
            return new string[,]
            {
               {  "No seasonal components","1"},
               {  "With seasonal components","1"}
            };
        }
        public string[,] getNameOfVectors()//returns the name of vectors needed for each analysis
        {
            return new string[,]
            {
               {  "No seasonal components","Vector A"},
               {  "With seasonal components","Vector B"}
            };
        }
        public string[,] getFunctionName()
        {
            return null;
        }
    }
}

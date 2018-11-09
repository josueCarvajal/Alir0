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
    class TimeSeries_Garch
    {
        public string getTitle()
        {
            return "Garch Analysis";
        }
        public string getDescription()
        {
            return "A set of analysis with the respective graphs";
        }
        public string[] getAnalysis()
        {
            return new string[] {
                "Autocorrelogram",
                "Histogram"
            };
        }
        public string[,] getNumberOfVectors()//returns the number vectors needed for each analysis
        {
            return new string[,]
            {
               {  "Autocorrelogram","1"},
               {  "Histogram","1"}
            };
        }
        public string[,] getNameOfVectors()//returns the name of vectors needed for each analysis
        {
            return new string[,]
            {
               {  "Autocorrelogram","Vector A"},
               {  "Histogram","Vector A"}
            };
        }
        public string[,] getFunctionName()
        {
            return null;
        }
    }
}

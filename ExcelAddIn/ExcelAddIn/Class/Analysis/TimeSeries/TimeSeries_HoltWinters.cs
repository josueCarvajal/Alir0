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
                "No trend level",
                "Exponential Smoothing"
            };
        }
        public string[,] getNumberOfVectors()//returns the number vectors needed for each analysis
        {
            return new string[,]
            {
               {"No trend level or seasonal components","3"},
               {"No trend level","3"},
               {"Exponential Smoothing","3"}
            };
        }
        public string[,] getNameOfVectors()//returns the name of vectors needed for each analysis
        {
            return new string[,]
            {
               {"No trend level or seasonal components","Xt"},
               {"No trend level or seasonal components","Periodicity"},
               {"No trend level or seasonal components","Projection"},
               {"No trend level","Xt"},
               {"No trend level","Periodicity"},
               {"No trend level","Projection"},
               {"Exponential Smoothing","Xt"},
               {"Exponential Smoothing","Periodicity"},
               {"Exponential Smoothing","Projection"},
            };
        }
        public string[,] getFunctionName()
        {
            return new string[,]
            {
               {"No trend level or seasonal components","HoltWinters_SinNivel_SinTendencia_SinComponenteEstacional"},
               {"No trend level","HoltWinters_SinNivel_SinTendencia"},
               {"Exponential Smoothing","HoltWinters_SinNivel_SuavizamientoExponencial"}
            };
        }
    }
}

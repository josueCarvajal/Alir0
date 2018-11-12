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
                "With seasonal components",
                "No seasonal components",
                "Arima proy - With seasonal components",
                "Arima proy -  No seasonal components"
            };
        }
        public string[,] getNumberOfVectors()//returns the number vectors needed for each analysis
        {
            return new string[,]
            {
               {"With seasonal components","2"},
               { "No seasonal components","2"},
               { "Arima proy - With seasonal components","3"},
               { "Arima proy -  No seasonal components","3"}
            };
        }
        public string[,] getNameOfVectors()//returns the name of vectors needed for each analysis
        {
            return new string[,]
            {
               {"With seasonal components","Xt"},
               {"With seasonal components","Periodicity"},
               {"No seasonal components","Xt"},
               {"No seasonal components","Periodicity"},
               {"Arima proy - With seasonal components","Xt"},
               {"Arima proy - With seasonal components","Periodicity"},
               {"Arima proy - With seasonal components","Projection"},
               {"Arima proy -  No seasonal components","Xt"},
               {"Arima proy -  No seasonal components","Periodicity"},
               {"Arima proy -  No seasonal components","Projection"}
            };
        }
        public string[,] getFunctionName()
        {
            return new string[,]
            {
               {"With seasonal components","Arima_ConComponenteEstacional"},
               { "No seasonal components","Arima_SinComponenteEstacional"},
               { "Arima proy - With seasonal components","ArimaProy_ConComponenteEstacional"},
               { "Arima proy -  No seasonal components","ArimaProy_SinComponenteEstacional"}
            };
        }
    }
}

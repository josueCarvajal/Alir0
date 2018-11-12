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
    class TimeSeries_Standard
    {
        public string getTitle()
        {
            return "Time Series Analysis";
        }
        public string getDescription()
        {
            return "A set of analysis with the respective graphs";
        }
        public string[] getAnalysis()
        {
            return new string[] {
                "Linear trend of the series",
                "Decomposition",
                "Random effect",
                "Trend effect",
                "Seasonal effect",
                "Autocorrelogram",
                "Partial autocorrelogram",
                "Cyclic boxplot",
                "Histogram",
                "Dickey-Fuller & Box Ljung Test"
            };
        }
        public string[,] getNumberOfVectors()//returns the number vectors needed for each analysis
        {
            return new string[,]
            {
               { "Linear trend of the series","2"},
               { "Decomposition","2"},
               { "Random effect","2"},
               { "Trend effect","2"},
               { "Seasonal effect","2"},
               { "Autocorrelogram","2"},
               { "Partial autocorrelogram","2"},
               { "Cyclic boxplot","2"},
               { "Histogram","2"},
               { "Dickey-Fuller & Box Ljung Test","2"}
            };
        }
        public string[,] getNameOfVectors()//returns the name of vectors needed for each analysis
        {
            return new string[,]
            {
               {"Linear trend of the series","Xt"},
               {"Linear trend of the series","Periodicity"},
               {"Decomposition","Xt"},
               {"Decomposition","Periodicity"},
               {"Random effect","Xt"},
               {"Random effect","Periodicity"},
               {"Trend effect","Xt"},
               {"Trend effect","Periodicity"},
               {"Seasonal effect","Xt"},
               {"Seasonal effect","Periodicity"},
               {"Autocorrelogram","Xt"},
               {"Autocorrelogram","Periodicity"},
               {"Partial autocorrelogram","Xt"},
               {"Partial autocorrelogram","Periodicity"},
               {"Cyclic boxplot","Xt"},
               {"Cyclic boxplot","Periodicity"},
               {"Histogram","Xt"},
               {"Histogram","Periodicity"},
               {"Dickey-Fuller & Box Ljung Test","Xt"},
               {"Dickey-Fuller & Box Ljung Test","Periodicity"},
            };
        }

        public string[,] getFunctionName()
        {
            return new string[,]
            {
               {"Linear trend of the series","SeriesTiempo_SerieEnAnalisis"},
               {"Decomposition","SeriesTiempo_DescomposicionDeLaSerie"},
               {"Random effect","SeriesTiempo_EfectoAleatorio"},
               {"Trend effect","SeriesTiempo_EfectoTendecial"},
               {"Seasonal effect","SeriesTiempo_EfectoEstacional"},
               {"Autocorrelogram","SeriesTiempo_Autocorrelograma"},
               {"Partial autocorrelogram","SeriesTiempo_AutocorrelogramaParcial"},
               { "Cyclic boxplot","SeriesTiempo_Boxplot"},
               { "Histogram","SeriesTiempo_Histograma"},
               { "Dickey-Fuller & Box Ljung Test","ts_DICKEY_FULLERYBOX_LJUNG"}
            };
        }
    }

}

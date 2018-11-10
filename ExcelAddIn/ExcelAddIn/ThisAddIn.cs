using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Windows.Forms;


namespace ExcelAddIn
{
    public partial class ThisAddIn
    {
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        void InternalStartup()
        {
        }

        public void BertCall(string functionName, String dataRange)
        {
            if(dataRange.Equals("00:00"))
            {
                MessageBox.Show("Please check your empty cells");
            }
            else
            {
                object resultado = Application.Run("BERT.Call", functionName, getCurrentActiveSheet().Range[dataRange]);
                MessageBox.Show(resultado.ToString());
            }
        }

        public void BertCallTEST(string functionName, string[] dataRangeParameters)
        {
            object resultado = 0; ;
            if (dataRangeParameters[0] != "00:00")//in all analysis, position 1 will be filled, if not, there's empty selection
            {
                switch (dataRangeParameters.Length)
                {
                    case 1:
                        System.Array myvalues = (System.Array)getCurrentActiveSheet().Range[dataRangeParameters[0]].Cells.Value;
                        // resultado = Application.Run("BERT.Call", functionName, getCurrentActiveSheet().Range[dataRangeParameters[0]].Value2);
                        break;
                    case 2:
                        //Excel.Range r = Application.Range[dataRangeParameters[0]];
                        //Application.Evaluate("R.SeriesTiempo_Histograma(A1:A167;4)");
                        //object[,] xt = getCurrentActiveSheet().Range[dataRangeParameters[0]].Cells.Value;
                        //Excel.Range r = Application.Range[dataRangeParameters[0]];
                        //resultado = Application.Run("BERT.Call", functionName,
                        //selectedRange, 4);
                        break;
                    case 3:
                        resultado = Application.Run("BERT.Call", functionName,
                            getCurrentActiveSheet().Range[dataRangeParameters[0]],
                           getCurrentActiveSheet().Range[dataRangeParameters[1]],
                           getCurrentActiveSheet().Range[dataRangeParameters[2]]
                           );
                        
                        break;
                    case 4:
                        resultado = Application.Run("BERT.Call", functionName,
                            getCurrentActiveSheet().Range[dataRangeParameters[0]],
                           getCurrentActiveSheet().Range[dataRangeParameters[1]],
                           getCurrentActiveSheet().Range[dataRangeParameters[2]],
                           getCurrentActiveSheet().Range[dataRangeParameters[3]]);
                        break;
                    case 5:
                        resultado = Application.Run("BERT.Call", functionName,
                            getCurrentActiveSheet().Range[dataRangeParameters[0]],
                           getCurrentActiveSheet().Range[dataRangeParameters[1]],
                           getCurrentActiveSheet().Range[dataRangeParameters[2]],
                           getCurrentActiveSheet().Range[dataRangeParameters[3]],
                           getCurrentActiveSheet().Range[dataRangeParameters[4]]
                           );
                        break;
                    default:
                        break;
                }

                MessageBox.Show(resultado.ToString());
            }
            else
            {
                MessageBox.Show("There's no data selected");
            }
                
            
        }

        List<double> rangeToList(Microsoft.Office.Interop.Excel.Range inputRng)
        {
            object[,] cellValues = (object[,])inputRng.Value2;
            List<double> lst = cellValues.Cast<object>().ToList().ConvertAll(x => Convert.ToDouble(x));
            return lst;
        }
        static float[,] toFloatArray(object arg)
        {
            float[,] result = null;

            if (arg is Array)
            {
                int rank = ((Array)arg).Rank;
                if (rank == 2)
                {
                    int rowCount = ((Array)arg).GetUpperBound(0);
                    int columnCount = ((Array)arg).GetLength(1);
                    result = new float[rowCount, columnCount];

                    for (int i = 0; i < columnCount ; i++)
                    {
                        for (int j = 0; j < rowCount; j++)
                        {
                            result[j, i] = float.Parse(((Array)arg).GetValue(j+1, i+1).ToString());
                        }
                    }
                }
            }
            return result;
        }
        static float[] convert(object arg)
        {
            float[] result = null;

            if (arg is Array)
            {
                int rank = ((Array)arg).Rank;
                if (rank == 2)
                {
                    int rowCount = ((Array)arg).GetUpperBound(0);
                    int columnCount = ((Array)arg).GetLength(1);
                    result = new float[rowCount];

                    for (int i = 0; i < columnCount; i++)
                    {
                        for (int j = 0; j < rowCount; j++)
                        {
                            result[j] = float.Parse(((Array)arg).GetValue(j + 1, i + 1).ToString());
                        }
                    }
                }
            }
            return result;
        }

        private Excel.Worksheet getCurrentActiveSheet()
        {
            Excel.Workbook currentWorkBook = this.Application.ActiveWorkbook;
            return currentWorkBook.ActiveSheet;
        }
        public void FillCellsFromDataBase(List<String> DataBaseQuery, String columnindex) {
                    
            Excel.Worksheet currentWorkBook = getCurrentActiveSheet();
            
            for (int i = 0; i < DataBaseQuery.Count; i++)
            {
                currentWorkBook.Range[columnindex + (i + 1)].Value2 = DataBaseQuery[i];
            }
            
            
        }
        
    }
}

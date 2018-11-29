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
            object resultado = 0;

            if (dataRangeParameters[0] != "00:00")//in all analysis, position 1 will be filled, if not, there's empty selection
            {

                switch (dataRangeParameters.Length)
                {
                    case 1:
                        Excel.Range v1 = Application.Range[dataRangeParameters[0]];
                        resultado = Application.Run("BERT.Call", functionName,v1);
                        break;
                    case 2:
                       Excel.Range ve1 = Application.Range[dataRangeParameters[0]];
                       Excel.Range ve2 = Application.Range[dataRangeParameters[1]];
                       resultado = Application.Run("BERT.Call", functionName,ve1, ve2);
                        break;
                    case 3:
                        Excel.Range vec1 = Application.Range[dataRangeParameters[0]];
                        Excel.Range vec2 = Application.Range[dataRangeParameters[1]];
                        Excel.Range vec3 = Application.Range[dataRangeParameters[2]];
                        resultado = Application.Run("BERT.Call", functionName,vec1,vec2,vec3);
                        break;
                    case 4:
                        Excel.Range vect1 = Application.Range[dataRangeParameters[0]];
                        Excel.Range vect2 = Application.Range[dataRangeParameters[1]];
                        Excel.Range vect3 = Application.Range[dataRangeParameters[2]];
                        Excel.Range vect4 = Application.Range[dataRangeParameters[3]];
                        resultado = Application.Run("BERT.Call", functionName,vect1,vect2,vect3,vect4);
                        break;
                    case 5:
                        Excel.Range vector1 = Application.Range[dataRangeParameters[0]];
                        Excel.Range vector2 = Application.Range[dataRangeParameters[1]];
                        Excel.Range vector3 = Application.Range[dataRangeParameters[2]];
                        Excel.Range vector4 = Application.Range[dataRangeParameters[3]];
                        Excel.Range vector5 = Application.Range[dataRangeParameters[4]];
                        resultado = Application.Run("BERT.Call", functionName, vector1, vector2, vector3, vector4, vector5);
                        break;
                    default:
                        break;
                }
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
<<<<<<< HEAD
            
            
        }

        public void InstallPackages(string Option)
        {
            if (Option == "1")
            {
                string functionName = "Instalar_Paquetes";
                object resultado = Application.Run("BERT.Call", functionName);
            }

        }

=======
            currentWorkBook.Columns.AutoFit();

        }
        
>>>>>>> old_database
    }
}

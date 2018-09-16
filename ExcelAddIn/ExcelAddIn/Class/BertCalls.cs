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
    class BertCalls
    {
        Validations validate = new Validations();

        public void bertCalls(string functionName)
        {
            Globals.ThisAddIn.BertCall(functionName, validate.getRange());
        }








        //R functions must be saved at local C:\Users\josue\Documents as BERT2 folder carefull with OneDrive/Documents.

        /*
         //this methods is just used here to TEST. Each function will be called from the respective class
        */
        public void Sumar() 
        {
            bertCalls("suma");
        }
        public void Histogram()
        {
            bertCalls("hist");
        }

    }
}

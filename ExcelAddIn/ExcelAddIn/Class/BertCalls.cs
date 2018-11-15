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

        public void bertCalls(string functionName,string[] range)
        {
            Globals.ThisAddIn.BertCallTEST(functionName, range);
        }

        public void bertInstallPackages()
        {
            string theOption;

            DialogResult dialogResult = MessageBox.Show("Do you want to install package graphics from https://cran.r-project.org?", "R packages", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes) 
            {
                theOption = "1";
                Globals.ThisAddIn.InstallPackages(theOption);
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("Cancel for the user", "Notificacion" );
            }
            
        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelAddIn.Help
{
    public partial class HelpWindow : Form
    {
        public HelpWindow()
        {
            InitializeComponent();
            this.Show();
        }

        private void btnFirstSteps_Click(object sender, EventArgs e)
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}PDF\\First stepd in ALIR0.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
           
            PdfViewer.src = FileName;
           
        }

        private void btnDatabaseModule_Click(object sender, EventArgs e)
        {
           /* string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}PDF\\DataBase Module.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
          var value = Properties.Resources.ResourceManager.GetObject("DataBase Module.pdf", Properties.Resources.Culture);*/
            PdfViewer.src = "C:/Users/KURISUTIAN/Desktop/II Semestre 2018/practica/DataBase Module.pdf";

        }

        private void btnTimeSeries_Click(object sender, EventArgs e)
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}PDF\\Time series module.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));

            PdfViewer.src = FileName;

        }

        private void btnCommonErrors_Click(object sender, EventArgs e)
        {
            string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
            string FileName = string.Format("{0}PDF\\Common errors.pdf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));
            MessageBox.Show(FileName);
            PdfViewer.src = FileName;

        }
    }
}

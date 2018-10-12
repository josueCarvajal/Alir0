using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelAddIn.DataBase
{
    public partial class ProgressBar : Form
    {
        public ProgressBar()
        {
            InitializeComponent();
           
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }


        private void bg_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Completo...");
            
        }

        private void bg_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            // Change the value of the ProgressBar to the BackgroundWorker progress.
            progressBarMain.Value = e.ProgressPercentage;
            progressBarMain.Step = 1;
            progressBarMain.Style = ProgressBarStyle.Continuous;
            progressBarMain.Minimum = 0;
            progressBarMain.Maximum = 100;

            if (e.ProgressPercentage > 100)
            {
                progressBarMain.Value = progressBarMain.Maximum;
            }
            else
            {
                  progressBarMain.Value = e.ProgressPercentage;
            }
        }

        public void loadWindow()
        {
            /*
            +WorkerReportsProgress = true;
            bg.ProgressChanged += bg_ProgressChanged;
            bg.DoWork += bg_DoWork;
            bg.RunWorkerCompleted += bg_RunWorkerCompleted;
            bg.RunWorkerAsync();
            labelProgreso.Visible = true;
            progressBar1.Visible = true;
            */
        }
    }
}

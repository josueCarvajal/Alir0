using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelAddIn.ProgressBar
{
    public partial class ProgressBarForm : Form
    {
        
        public ProgressBarForm()
        {
            this.Show();
            InitializeComponent();
            StartProgressBar();
        }

        public void StartProgressBar() {
            progressBarmain.Style = ProgressBarStyle.Marquee;
            progressBarmain.MarqueeAnimationSpeed = 50;

        }
       

        public void FinishProcess()
        {
            progressBarmain.Style = ProgressBarStyle.Blocks;
            progressBarmain.MarqueeAnimationSpeed = 0;
            this.Close();
            
        }


        private void ProgressBarFormBackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            
            ExcelAddIn.DataBase.scfc databaseWindowObjet = (ExcelAddIn.DataBase.scfc) e.Argument;
           
            databaseWindowObjet.DisableEnableUI();
            databaseWindowObjet.AddInstancesTocbInstances();
            databaseWindowObjet.DisableEnableUI();
           
        }

        private void BGWQueryToDataBase_DoWork(object sender, DoWorkEventArgs e)
        {
            
            ExcelAddIn.DataBase.scfc databaseWindowObjet = (ExcelAddIn.DataBase.scfc)e.Argument;
            databaseWindowObjet.DisableEnableUI();
            databaseWindowObjet.QueryToDatabase();
            databaseWindowObjet.DisableEnableUI();
        }
        

        private void ProgressBarFormBackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
           FinishProcess();
        }

        private void BGWQueryToDataBase_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            FinishProcess();
        }
                     
        public delegate void ProgressUpdatedCallaback(ProgressBar.ProgressUpdatedEventArgs progress);

        private void Processor_ProgressUpdated(ProgressBar.ProgressUpdatedEventArgs progressUpdated)
        {
            if (InvokeRequired)
            {
                Invoke(new ProgressUpdatedCallaback(this.UpdateProgress), new object[] { progressUpdated });
            }
            else
            {
                UpdateProgress(progressUpdated);
            }
        }

        private void UpdateProgress(ProgressBar.ProgressUpdatedEventArgs args)
        {
           Application.DoEvents();

        }
        
        public delegate void ProgressUpdatedEvent(ProgressUpdatedEventArgs progressUpdated);

    }
}

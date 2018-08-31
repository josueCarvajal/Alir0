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
    public partial class DataBaseWindow : Form
    {
        DataBaseConection Conection = new DataBaseConection();

        public DataBaseWindow()
        {
            InitializeComponent();
            AddInstancesTocbInstances();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {

        }

        private void AddInstancesTocbInstances()
        {

            this.Show();

            string[] instancias;
            instancias = Conection.InstalledInstances();
            foreach (string s in instancias)
            {
                if (s == "MSSQLSERVER")
                {
                    cbInstances.Items.Add("(local)");
                }
                else
                {
                    cbInstances.Items.Add(@"(local)\" + s);
                }
            }
            cbInstances.Text = "(local)";



        }
    }
}

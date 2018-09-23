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
             cbInstances.DataSource = Conection.Installedinstances();
            
        }

        private void cbInstances_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string Instances = cbInstances.SelectedItem.ToString();
            this.Show();
            CbDataBaseName.DataSource = Conection.InstalledDataBase(Instances);

        }

        private void CbDataBaseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Instances = cbInstances.SelectedItem.ToString();
            string DataBase = CbDataBaseName.SelectedItem.ToString();
            
                cbTableName.DataSource = Conection.TablesInDataBase(Instances, DataBase);
        }

        private void cbTableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Instances = cbInstances.SelectedItem.ToString();
            string DataBase = CbDataBaseName.SelectedItem.ToString();
            string Table= cbTableName.SelectedItem.ToString();

            cbColumn.DataSource = Conection.GetColumnsOfTable(Instances, DataBase, Table);
        }

        private void cbColumn_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


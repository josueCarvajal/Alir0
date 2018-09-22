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
            MessageBox.Show("r");
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {

        }

        private void AddInstancesTocbInstances()
        {

            this.Show();

            /* string[] instancias;
             instancias = Conection.InstalledInstances();
             foreach (string s in instancias)
             {
                 /* if (s == "MSSQLSERVER")
                  {
                      cbInstances.Items.Add("(local)");
                  }
                  else
                  {*/
            //cbInstances.Items.Add(@"(local)\" + s);
            // }
            cbInstances.DataSource = Conection.Installedinstances();




        }

        private void AddTablesTocbTablesName(string Instances, string Database)
        {
            cbTableName.DataSource = Conection.TablesInDataBase(Instances, Database);
            cbTableName.ValueMember = "table_name";

        }

        private void AddDataBasesTocbDataBase(String instancesName)
        {
            MessageBox.Show(instancesName);

            this.Show();

            string[] instancias;
            instancias = Conection.InstalledDataBase(instancesName);
            foreach (string s in instancias)
            {

                CbDataBaseName.Items.Add(s);

            }
        }

        private void AddColumnsTocbColumns(string Instances, string Database,string table)
        {
            cbColumn.DataSource = Conection.ColumnsOfTable(Instances, Database, table);
            cbColumn.ValueMember = "columns_name";

        }



        private void cbInstances_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            AddDataBasesTocbDataBase(cbInstances.SelectedItem.ToString());
        }

        private void CbDataBaseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddTablesTocbTablesName(cbInstances.SelectedItem.ToString(), CbDataBaseName.SelectedItem.ToString());

        }

        private void cbTableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddColumnsTocbColumns(cbInstances.SelectedItem.ToString(), CbDataBaseName.SelectedItem.ToString(), cbTableName.SelectedItem.ToString());
        }
    }
}


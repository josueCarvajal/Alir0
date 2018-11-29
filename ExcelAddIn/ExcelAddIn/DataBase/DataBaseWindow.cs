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
    public partial class scfc : Form
    {
        DataBaseConection Conection = new DataBaseConection();
        List<string> EmptyList = new List<string>();
        List<string> AuxiliarList = new List<string>();
      
        public scfc()
        {
            
            InitializeComponent();
            DisableEnableUI();
            this.Show();
            StartForm();
          
        }

        public void DisableEnableUI()
        {
            DisableEnableComboBox(cbInstances);
            DisableEnableComboBox(CbDataBaseName);
            DisableEnableComboBox(cbTableName);
            DisableEnableComboBox(cbColumn);
            //disable button
            DisableEnableButton(btnAdd);
            DisableEnableButton(btnRemove);
            DisableEnableButton(btnOk);
        }
        
        public void DisableEnableComboBox(ComboBox combobox)
        {

            if (combobox.InvokeRequired)
                combobox.Invoke((MethodInvoker)delegate ()
                {
                    if (combobox.Enabled == true)
                    {
                        combobox.Enabled = false;
                    }
                    else { combobox.Enabled = true; }
                });
        }

        public void DisableEnableButton(Button button) {

            if (button.InvokeRequired)
                button.Invoke((MethodInvoker)delegate ()
                {
                    if (button.Enabled == true)
                    {
                        button.Enabled = false;
                    }
                    else { button.Enabled = true; }
                });
        }
      

        public void StartForm() {
            DisableEnableUI();
            ProgressBar.ProgressBarForm ProgressBar = new ProgressBar.ProgressBarForm();
            scfc ObjectDatabase = this;
            ProgressBar.ProgressBarFormBackgroundWorker.RunWorkerAsync(ObjectDatabase);
           
        }


        public void CleanColumnList()
        {
            LbSelectedColumns.Items.Clear();
        }

        public void AddInstancesTocbInstances()
        {
       
            List<string> ListOfInstances= Conection.Installedinstances();
            
            if (ListOfInstances.Count != 0)
            {
                if (cbInstances.InvokeRequired)
                    cbInstances.Invoke((MethodInvoker)delegate ()
                    {
                        cbInstances.DataSource = ListOfInstances;
                    });
                else { cbInstances.DataSource = ListOfInstances; }

                
            }
            else
            {
                MessageBox.Show("The aplication not found instances of SQL\n Make sure the SQL Server Browser service is activated");
            }
          
        }
       
        private void cbInstances_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CleanColumnList();
            string Instances = cbInstances.SelectedItem.ToString();

            CbDataBaseName.DataSource = EmptyList;
            cbTableName.DataSource = EmptyList;
            cbColumn.DataSource = EmptyList;

            AuxiliarList = Conection.InstalledDatabases(Instances);
            CbDataBaseName.DataSource = AuxiliarList;
            if (CbDataBaseName.DataSource == null)
            {
                MessageBox.Show("There are no databases in the instance " + Instances);
                return;
            }
        }

        private void CbDataBaseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            CleanColumnList();
            string Instances = cbInstances.SelectedItem.ToString();
            string DataBase = CbDataBaseName.SelectedItem.ToString();

            cbTableName.DataSource = EmptyList;
            cbColumn.DataSource = EmptyList;

            cbTableName.DataSource = Conection.TablesInDataBase(Instances, DataBase);
            if (cbTableName.DataSource == null)
            {
                MessageBox.Show("There are no tables in the database " + DataBase);
                return;
            }
        }

        private void cbTableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            CleanColumnList();

            string Instances = cbInstances.SelectedItem.ToString();
            string DataBase = CbDataBaseName.SelectedItem.ToString();
            string Table = cbTableName.SelectedItem.ToString();

            cbColumn.DataSource = EmptyList;
            cbColumn.DataSource = Conection.GetColumnsOfTable(Instances, DataBase, Table);
            if (cbColumn.DataSource == null)
            {
                MessageBox.Show("There are no columns in the table " + Table);
                return;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbColumn.SelectedItem != null)
            {
                string Column = cbColumn.SelectedItem.ToString();
                if (ColumnDoesntExists(Column))
                {
                    LbSelectedColumns.Items.Add(Column);
                }

            }
            else
            {
                MessageBox.Show("Columns is empty");
            }

        }

        public bool ColumnDoesntExists(String columnName)
        {
            bool Exists = true;

            foreach (var item in LbSelectedColumns.Items)
            {
                if (item.ToString() == columnName)
                {
                    Exists = false;
                    MessageBox.Show("The specified column has already been added");
                }
            }
            return Exists;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
           if (LbSelectedColumns.SelectedIndex != -1)
            {
                LbSelectedColumns.Items.RemoveAt(LbSelectedColumns.SelectedIndex);
            }
            else { MessageBox.Show("You must select an item from the list"); }
                   
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            DisableEnableUI();
           ProgressBar.ProgressBarForm ProgressBar = new ProgressBar.ProgressBarForm();
            scfc ObjectDatabase = this;
            ProgressBar.BGWQueryToDataBase.RunWorkerAsync(ObjectDatabase);
            this.Show();
           
        }

        public void QueryToDatabase()
        {
            if (validateOperation(cbColumn))
            {
                string Instances="";
                string DataBase = ""; 
                string Table = ""; 

                
                if (cbInstances.InvokeRequired)
                    cbInstances.Invoke((MethodInvoker)delegate ()
                    {
                        Instances = cbInstances.SelectedItem.ToString();
                    });
                else { Instances = cbInstances.SelectedItem.ToString(); }

                if (CbDataBaseName.InvokeRequired)
                    CbDataBaseName.Invoke((MethodInvoker)delegate ()
                    {
                        DataBase = CbDataBaseName.SelectedItem.ToString();
                    });
                else { DataBase = CbDataBaseName.SelectedItem.ToString(); }

                if (cbTableName.InvokeRequired)
                    cbTableName.Invoke((MethodInvoker)delegate ()
                    {
                        Table = cbTableName.SelectedItem.ToString();
                    });
                else { Table = cbTableName.SelectedItem.ToString(); }



                List<string> SQLquery = new List<string>();
                List<string> ColumnIndex = new List<string>();
                
                ColumnIndex.Add("A");
                ColumnIndex.Add("B");
                ColumnIndex.Add("C");
                ColumnIndex.Add("D");
                ColumnIndex.Add("E");
                ColumnIndex.Add("F");
                ColumnIndex.Add("G");
                ColumnIndex.Add("H");
                ColumnIndex.Add("I");
                ColumnIndex.Add("J");

                for (int i = 0; i < LbSelectedColumns.Items.Count; i++)
                {
                    SQLquery = Conection.SQLQueryToColumn(Instances, DataBase, Table, LbSelectedColumns.Items[i].ToString());

                    if (SQLquery.Count == 0)
                    {
                        MessageBox.Show("The query not found results");
                        return;
                    }

                    Globals.ThisAddIn.FillCellsFromDataBase(SQLquery, ColumnIndex[i]);
                }
            }
        }

        public Boolean validateOperation(ComboBox cbColumns) {

            Boolean itisValited = true;
            if (LbSelectedColumns.Items.Count==0)
            {
                itisValited = false;
                MessageBox.Show("There is not item added in the list");
            }
            
            if (LbSelectedColumns.Items.Count >= 11)
            {
                itisValited = false;
                MessageBox.Show("The maximum number of items you can select is 10");
            }

            return itisValited;
        }

    }
}


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
            this.Show();
           AddInstancesTocbInstances();
           
        }

        public void CleanColumnList() {
              LbSelectedColumns.Items.Clear();
        }
        private void AddInstancesTocbInstances()
        {
            this.Show();
<<<<<<< HEAD

=======
            cbInstances.DataSource = Conection.InstalledInstances();
>>>>>>> 5ea27c6ea66697fedcde3c5a87fbe148ab697b3c
           
                cbInstances.DataSource = Conection.Installedinstances();

                if (cbInstances.Items.Count == 0)
                {
                    string[] instancias;
                    instancias = Conection.InstalledInstances();

                    foreach (string s in instancias)
                    {

                        cbInstances.Items.Add(@"(local)\" + s);

                    }
                }
              
        }

       
        private void cbInstances_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            CleanColumnList();
            string Instances = cbInstances.SelectedItem.ToString();

            CbDataBaseName.DataSource = EmptyList;
            cbTableName.DataSource = EmptyList;
            cbColumn.DataSource = EmptyList;
            
            AuxiliarList= Conection.InstalledDatabases(Instances);
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
            if (cbTableName.DataSource==null)
            {
                MessageBox.Show("There are no tables in the database "+DataBase);
                return;
            }
           
        }

        private void cbTableName_SelectedIndexChanged(object sender, EventArgs e)
        {
            CleanColumnList();

            string Instances = cbInstances.SelectedItem.ToString();
            string DataBase = CbDataBaseName.SelectedItem.ToString();
            string Table= cbTableName.SelectedItem.ToString();

            cbColumn.DataSource = EmptyList;
            cbColumn.DataSource = Conection.GetColumnsOfTable(Instances, DataBase, Table);
            if (cbColumn.DataSource == null)
            {
                MessageBox.Show("There are no columns in the table " + Table);
                return;
            }
        }

        private void cbColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
                     
            
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
            else {
                MessageBox.Show("column is empty");
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
            if (LbSelectedColumns.Items.Count==0)
            {
                MessageBox.Show("There is not columns added in the list");
                return;
               
            }
            if (LbSelectedColumns.Items.Count <= 11) {
                MessageBox.Show("The maximum number of items you can select is 10");
                return;
            }
            string Instances = cbInstances.SelectedItem.ToString();
            string DataBase = CbDataBaseName.SelectedItem.ToString();
            string Table = cbTableName.SelectedItem.ToString();

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
                Globals.ThisAddIn.FillCellsFromDataBase(SQLquery,ColumnIndex[i]);
            }
          

        }
<<<<<<< HEAD
                                  
=======

        private void scfc_Load(object sender, EventArgs e)
        {

        }






        //  ProgressBar bg = new ProgressBar();




>>>>>>> 5ea27c6ea66697fedcde3c5a87fbe148ab697b3c

    }
}


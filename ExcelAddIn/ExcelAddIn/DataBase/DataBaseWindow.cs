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

        public scfc()
        {
            InitializeComponent();
            this.Show();
           AddInstancesTocbInstances();
           
        }
      
        private void AddInstancesTocbInstances()
        {
            this.Show();
            cbInstances.DataSource = Conection.InstalledInstances();
           
        }
       
        private void cbInstances_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           string Instances = cbInstances.SelectedItem.ToString();
           

            LbSelectedColumns.Items.Clear();

            CbDataBaseName.DataSource = Conection.InstalledDataBase(Instances);
            
        }

        private void CbDataBaseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Instances = cbInstances.SelectedItem.ToString();
            string DataBase = CbDataBaseName.SelectedItem.ToString();

            LbSelectedColumns.Items.Clear();
            cbTableName.DataSource = Conection.TablesInDataBase(Instances, DataBase);
           
        }

        private void cbTableName_SelectedIndexChanged(object sender, EventArgs e)
        {
           string Instances = cbInstances.SelectedItem.ToString();
            string DataBase = CbDataBaseName.SelectedItem.ToString();
            string Table= cbTableName.SelectedItem.ToString();

            LbSelectedColumns.Items.Clear();
            cbColumn.DataSource = Conection.GetColumnsOfTable(Instances, DataBase, Table);
            
        }

        private void cbColumn_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* List<string> SQLquery = new List<string>();
            string Instances = cbInstances.SelectedItem.ToString();
            string DataBase = CbDataBaseName.SelectedItem.ToString();
            string Table = cbTableName.SelectedItem.ToString();
            string Column= cbColumn.SelectedItem.ToString();

            SQLquery = Conection.SQLQueryToColumn(Instances, DataBase, Table, Column);
            Globals.ThisAddIn.FillCellsFromDataBase(SQLquery);
            */
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
           string Column = cbColumn.SelectedItem.ToString();

            if (ColumnDoesntExists(Column))
            {
                LbSelectedColumns.Items.Add(Column);
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

        private void btnConnect_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (LbSelectedColumns.Items.Count==0)
            {
                MessageBox.Show("You must select a column");
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
           /* foreach (var item in LbSelectedColumns.Items)
            {
                
                SQLquery = Conection.SQLQueryToColumn(Instances, DataBase, Table, item.ToString());
                Globals.ThisAddIn.FillCellsFromDataBase(SQLquery);
            }
            */

        }

        private void scfc_Load(object sender, EventArgs e)
        {

        }






        //  ProgressBar bg = new ProgressBar();





    }
}


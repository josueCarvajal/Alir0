using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelAddIn.DataBase
{
    class DataBaseConection
    {

        SqlConnection SqlConexion;
        public DataBaseConection()
        {
            
        }

        public List<String> Installedinstances()
        {

            SqlDataSourceEnumerator servers;
            DataTable serversTable;
            List<String> serversList;

            servers = SqlDataSourceEnumerator.Instance;
            serversTable = new DataTable();
            
            serversTable = servers.GetDataSources();
            
            serversList = new List<string>();
            
            foreach (DataRow rowServidor in serversTable.Rows)
            {
               
                if (String.IsNullOrEmpty(rowServidor["InstanceName"].ToString()))
                    serversList.Add(rowServidor["ServerName"].ToString());
                else
                    serversList.Add(rowServidor["ServerName"] + "\\" + rowServidor["InstanceName"]);
            }
            
            return serversList;
        }

        public string[] InstalledInstances()
        {
            Microsoft.Win32.RegistryKey rk;//C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL
            rk = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server", false);
            string[] s;
            s = ((string[])rk.GetValue("InstalledInstances"));
            return s;
        }

        public List<String> InstalledDatabases(string instances) {

            List<String> bases = new List<string>();
            string[] basesSys = { "master", "model", "msdb", "tempdb" };
            DataTable dt = new DataTable();
            string dataBase = "master";
            string sel = "SELECT name FROM sysdatabases";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sel, OpenConection(instances, dataBase));
                da.Fill(dt);
                CloseConection(SqlConexion);
                foreach (DataRow row in dt.Rows)
                {
                   
                    foreach (DataColumn Columns in dt.Columns)
                    {
                        
                            if (Array.IndexOf(basesSys, row[Columns].ToString()) ==-1)
                            {
                                bases.Add(row[Columns].ToString());
                            }
                                             
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error al recuperar las bases de la instancia indicada",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return bases;
        }
                 
        public List<String> TablesInDataBase(string instances, string dataBase)
        {
            List<string> result = new List<string>();
            SqlCommand cmd = new SqlCommand("SELECT name FROM sys.Tables", OpenConection(instances, dataBase));
            System.Data.SqlClient.SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                result.Add(reader["name"].ToString());
            CloseConection(SqlConexion);
            return result;
        }
        public SqlConnection OpenConection(string instances, string dataBase)

        {
            var connStrBldr = new System.Data.SqlClient.SqlConnectionStringBuilder();
            connStrBldr.DataSource = instances;
            connStrBldr.InitialCatalog = dataBase;
            connStrBldr.IntegratedSecurity = true;

            SqlConexion = new SqlConnection(connStrBldr.ToString());
            SqlConexion.Open();
            return SqlConexion;
        }

        public void CloseConection(SqlConnection conection)
        {
            conection.Close();

        }

        public List<string> GetColumnsOfTable(string instances, string dataBase, string tableName)
        {
            List<string> colList = new List<string>();
            DataTable dataTable = new DataTable();

            //string cmdString = String.Format("SELECT TOP 0 * FROM {0}", tableName);
            string cmdString = "SELECT TOP 0 * FROM " + tableName;

            using (SqlDataAdapter dataContent = new SqlDataAdapter(cmdString, OpenConection(instances, dataBase)))
            {
                dataContent.Fill(dataTable);
                CloseConection(SqlConexion);
                foreach (DataColumn col in dataTable.Columns)
                {
                    colList.Add(col.ColumnName);
                }
            }
            return colList;
        }
        public List<string> SQLQueryToColumn(string instances, string dataBase, string tableName,string column)
        {
            List<string> SQLquery = new List<string>();
            DataTable dataTable = new DataTable();

            string cmdString = String.Format("SELECT {0} FROM  {1}",column, tableName);

            using (SqlDataAdapter dataContent = new SqlDataAdapter(cmdString, OpenConection(instances, dataBase)))
            {
                dataContent.Fill(dataTable);
                CloseConection(SqlConexion);
                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (var item in row.ItemArray)
                    SQLquery.Add(item.ToString());
                }
            }
            return SQLquery;

        }

    }
}


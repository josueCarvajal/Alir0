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
        string servidor;

        public DataBaseConection()
        {
            //servidores = SqlDataSourceEnumerator.Instance;
            // tablaservidores = new DataTable();
        }

        public List<String> Installedinstances()
        {

            SqlDataSourceEnumerator servidores;
            DataTable tablaservidores;
            List<String> listaservidores;

            servidores = SqlDataSourceEnumerator.Instance;
            tablaservidores = new DataTable();

            // Obtenemos un dataTable con la información sobre las instancias visibles
            // de SQL Server 2000 y 2005
            tablaservidores = servidores.GetDataSources();
            // Creamos una lista para que sea el origen de datos del combobox
            listaservidores = new List<string>();
            // Recorremos el dataTable y añadimos un valor nuevo a la lista con cada fila
            foreach (DataRow rowServidor in tablaservidores.Rows)
            {
                // La instancia de SQL Server puede tener nombre de instancia 
                //o únicamente el nombre del servidor, comprobamos si hay 
                //nombre de instancia para mostrarlo
                if (String.IsNullOrEmpty(rowServidor["InstanceName"].ToString()))
                    listaservidores.Add(rowServidor["ServerName"].ToString());
                else
                    listaservidores.Add(rowServidor["ServerName"] + "\\" + rowServidor["InstanceName"]);
            }

            // Asignamos al origen de datos del combobox la lista con 
            // las instancias de servidores
            // cbInstances.DataSource = listaservidores;

            return listaservidores;
        }

        public string[] InstalledInstances()
        {
            Microsoft.Win32.RegistryKey rk;
            rk = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server", false);
            string[] s;
            s = ((string[])rk.GetValue("InstalledInstances"));
            return s;
        }

        public String[] InstalledDataBase(string instances)
        {
            // Las bases de datos propias de SQL Server
            string[] basesSys = { "master", "model", "msdb", "tempdb" };
            string[] bases;
            DataTable dt = new DataTable();
            // Usamos la seguridad integrada de Windows
            string sCnn = "Server=" + instances + "; database=master; integrated security=yes";

            // La orden T-SQL para recuperar las bases de master
            string sel = "SELECT name FROM sysdatabases";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sel, sCnn);
                da.Fill(dt);
                bases = new string[dt.Rows.Count - 1];
                int k = -1;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string s = dt.Rows[i]["name"].ToString();
                    // Solo asignar las bases que no son del sistema
                    if (Array.IndexOf(basesSys, s) == -1)
                    {
                        k += 1;
                        bases[k] = s;
                    }
                }
                if (k == -1) return null;
                // ReDim Preserve
                {
                    int i1_RPbases = bases.Length;
                    string[] copyOf_dataBases = new string[i1_RPbases];
                    Array.Copy(bases, copyOf_dataBases, i1_RPbases);
                    bases = new string[(k + 1)];
                    Array.Copy(copyOf_dataBases, bases, (k + 1));
                };
                return bases;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error al recuperar las bases de la instancia indicada",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
 
        public List<String> TablesInDataBase(string instances, string dataBase)
        {
            List<string> result = new List<string>();
            SqlCommand cmd = new SqlCommand("SELECT name FROM sys.Tables", OpenConection(instances, dataBase));
            System.Data.SqlClient.SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                result.Add(reader["name"].ToString());
            return result;
        }
        public SqlConnection OpenConection(string instances, string dataBase)
        {
            SqlConnection conexion = new SqlConnection("Data Source=" + instances + "; Initial Catalog=" + dataBase + "; Integrated Security = True");
            conexion.Open();
            return conexion;
        }
        
        public List<string> GetColumnsOfTable(string instances, string dataBase, string tableName)
        {
            List<string> colList = new List<string>();
            DataTable dataTable = new DataTable();

            string cmdString = String.Format("SELECT TOP 0 * FROM {0}", tableName);

            using (SqlDataAdapter dataContent = new SqlDataAdapter(cmdString, OpenConection(instances, dataBase)))
            {
                dataContent.Fill(dataTable);

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


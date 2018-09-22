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


        public DataTable ColumnsOfTable(string instances, string dataBase, string Table) {
          //  string sCnn = "Server=" + instances + "; database=master; integrated security=yes";

            // La orden T-SQL para recuperar las bases de master
            
           // var columnNames = ctx.ExecuteQuery<string>("SELECT name FROM sys.columns WHERE object_id = OBJECT_ID('your table name');");

            SqlDataAdapter adapter = new SqlDataAdapter("SELECT name FROM sys.columns WHERE object_id = OBJECT_ID('your table name');", OpenConection(instances, dataBase));
            DataTable columns = new DataTable("columns");
            adapter.Fill(columns);
          
            return columns;
        }

        public DataTable TablesInDataBase(string instances, string dataBase)
        {

            SqlDataAdapter adapter = new SqlDataAdapter("select* from information_schema.tables", OpenConection(instances, dataBase));
            DataTable tables = new DataTable("tables");
            adapter.Fill(tables);
            return tables;

        }

        public SqlConnection OpenConection(string instances, string dataBase)
        {
            SqlConnection conexion = new SqlConnection("Data Source=" + instances + "; Initial Catalog=" + dataBase + "; Integrated Security = True");
            conexion.Open();
            return conexion;
        }



    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelAddIn.DataBase
{
    class DataBaseConection
    {

        public string[] InstalledInstances()
        {
            Microsoft.Win32.RegistryKey rk;
            rk = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server", false);
            string[] s;
            s = ((string[])rk.GetValue("InstalledInstances"));
            return s;
        }

    }

   
}

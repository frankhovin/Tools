using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace ConfluencePageBackup.OS {
    public class BrowserInfo {
        /*public System.String[] GetInstalledBrowsers () {
            var installedbrowsers = Registry.LocalMachine.OpenSubKey("SOFTWARE").OpenSubKey("Clients").
                OpenSubKey("StartMenuInternet").GetSubKeyNames();//.ToArray();// ToString();

            //foreach (var value in installedbrowsers)
            //    Console.WriteLine(value);

            return installedbrowsers;
        }*/

        public List<string> GetInstalledBrowsers() {
            List<string> oses = new List<string>();
            string[] osstring = ReadOsesFromReg();

            foreach (var value in osstring)
                oses.Add(value);

            return oses;
        }

        /**
         * Read the list of installed browsers from the registry and return as a string.
         */
        public string[] ReadOsesFromReg() {
            var installedbrowsers = Registry.LocalMachine.OpenSubKey("SOFTWARE").OpenSubKey("Clients").
                   OpenSubKey("StartMenuInternet").GetSubKeyNames().ToArray();//.ToArray();// ToString();

            return installedbrowsers;
        }
    }

    /*public class OS {
        public string osname { get; set; }
    }*/
}

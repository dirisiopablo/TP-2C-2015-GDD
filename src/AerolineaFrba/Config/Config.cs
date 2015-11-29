using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Utilities;

namespace AerolineaFrba.Config {
    
    public static class DBConfig {
        static public string currentDir = Environment.CurrentDirectory;
        static public DirectoryInfo directory = new DirectoryInfo(Path.GetFullPath(Path.Combine(currentDir, @"..\..\Config\")));
        static public string directoryString = directory.ToString();
        static public IniFile inifile = new IniFile(directoryString + "\\config.ini");

        static public string direccion = inifile.GetString("DB", "direccion", "");
        static public string database = inifile.GetString("DB", "database", "");
        static public string username = inifile.GetString("DB", "username", "");
        static public string password = inifile.GetString("DB", "password", "");

    }

    public static class SystemConfig
    {
        static public string currentDir = Environment.CurrentDirectory;
        static public DirectoryInfo directory = new DirectoryInfo(Path.GetFullPath(Path.Combine(currentDir, @"..\..\Config\")));
        static public string directoryString = directory.ToString();
        static public IniFile inifile = new IniFile(directoryString + "\\config.ini");


        static public DateTime systemDate = Convert.ToDateTime(inifile.GetString("FECHA", "fecha", ""));
        
    }

}

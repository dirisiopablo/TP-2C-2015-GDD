using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;

namespace AerolineaFrba.Config {
    
    public static class DBConfig {

        static public IniFile inifile = new IniFile("C://Development/TP-2C-2015-GDD/src/AerolineaFrba/Config/config.ini");

        static public string direccion = inifile.GetString("DB", "direccion", "");
        static public string database = inifile.GetString("DB", "database", "");
        static public string username = inifile.GetString("DB", "username", "");
        static public string password = inifile.GetString("DB", "password", "");

    }

    public static class SystemConfig {

        static public IniFile inifile = new IniFile("C://Development/TP-2C-2015-GDD/src/AerolineaFrba/Config/config.ini");

        static public DateTime systemDate = Convert.ToDateTime(inifile.GetString("FECHA", "fecha", ""));
        
    }

}

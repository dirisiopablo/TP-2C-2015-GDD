using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using AerolineaFrba.Interfaces;
using AerolineaFrba.Config;

namespace AerolineaFrba.Services {

    public static class DAO {

        private static SqlConnection _sqlCon;
        private static string _direccion;
        private static string _database;
        private static string _username;
        private static string _password;
        private static string _strCon;
        
        static public Exception exception;

        public static void connect() {
            _direccion = DBConfig.direccion;
            _database = DBConfig.database;
            _username = DBConfig.username;
            _password = DBConfig.password;

            _strCon = makeStringConnection(_direccion, _database, _username, _password);
            _sqlCon = new SqlConnection(_strCon);
        }

        public static void connect(string direccion, string database, string username, string password) {
            _direccion = direccion;
            _database  = database;
            _username  = username;
            _password  = password;

            _strCon = makeStringConnection(_direccion, _database, _username, _password);
            _sqlCon = new SqlConnection(_strCon);
        }

        public static DataTable select<T>() {

            String tablename = (String)typeof(T).GetField("TableName").GetValue(null);

            if (tablename == null) throw new Exception("Type " + typeof(T) + "has no static field named TableName.");

            if (_sqlCon == null) throw new Exception("Must call connect() before calling any DAO's method.");

            _sqlCon.Open();

            string query = "SELECT * FROM " + tablename;
            SqlCommand command = new SqlCommand(query, _sqlCon);

            DataTable datatable = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(datatable);
            adapter.Dispose();

            return datatable;
        }

        public static int save<T>(T entity, string TableName) {
            
            _sqlCon.Open();
            string query = "INSERT INTO "+TableName+" (";
            string queryValues = "VALUES (";

            var props = entity.GetType().GetProperties();

            foreach (var prop in props) {
                query += prop.Name + ",";

                if (String.Equals(prop.PropertyType.Name, "String"))
                    queryValues += "'" + prop.GetValue(entity) + "'" + ",";
                else
                    queryValues += prop.GetValue(entity) + ",";
            }

            query = query.Substring(0, query.Length - 2);
            queryValues = queryValues.Substring(0, queryValues.Length - 2);

            query += ") ";
            queryValues += ")";

            query += queryValues;

            SqlCommand command = new SqlCommand(query, _sqlCon);
            int rowsAffected = command.ExecuteNonQuery();

            return rowsAffected;

        }


        private static string makeStringConnection(string direccion, string database, string username, string password){
             return "Data Source=" + direccion + ";Initial Catalog=" +
                     database + ";User ID=" + username + ";Password=" + password + ";";
        }


        //TODO borrar esto
        public static List<TSalida> map<TEntrada, TSalida>(Func<TEntrada, TSalida> function, List<TEntrada> list) {

            List<TSalida> mappedList = new List<TSalida>();

            foreach (TEntrada item in list)
                mappedList.Add(function(item));

            return mappedList;

        }

    }
}

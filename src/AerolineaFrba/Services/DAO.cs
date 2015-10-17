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

        public static void connect() { //default connection
            _direccion = DBConfig.direccion;
            _database = DBConfig.database;
            _username = DBConfig.username;
            _password = DBConfig.password;

            _strCon = makeStringConnection(_direccion, _database, _username, _password);
            _sqlCon = new SqlConnection(_strCon);
        }

        public static void connect(string direccion, string database, string username, string password) { //custom connection
            _direccion = direccion;
            _database  = database;
            _username  = username;
            _password  = password;

            _strCon = makeStringConnection(_direccion, _database, _username, _password);
            _sqlCon = new SqlConnection(_strCon);
        }

        public static void closeConnection() {

            if (_sqlCon != null) _sqlCon.Close();

        }

        /* 
         * PARA QUE FUNCIONE BIEN, LOS ATRIBUTOS DE LOS OBJ TIENEN QUE ESTAR EN EL MISMO ORDEN QUE LAS COLUMNAS EN LAS TABLAS,
         * ATRIBUTOS DE TABLAS INTERMEDIAS Y ATRIBUTOS EXTRA AL FINAL
         */
        public static T selectOne<T>(String[] filters) where T: new() {

            String tablename = (String)typeof(T).GetField("TableName").GetValue(null);

            if (tablename == null) throw new Exception("Type " + typeof(T) + "has no static field named TableName.");

            if (_sqlCon == null) throw new Exception("Must call connect() before calling any DAO's method.");

            if (_sqlCon.State == ConnectionState.Closed) _sqlCon.Open();

            string query = "SELECT * FROM " + tablename;

            if (filters != null && filters.Length != 0) {

                query += " WHERE ";

                foreach (String where in filters) {
                    query += where;
                    query += " AND ";
                }

                query = query.Substring(0, query.Length - 5); //saca el ultimo 'and'

            }

            SqlCommand command = new SqlCommand(query, _sqlCon);

            T obj = new T();

            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            Object[] values = new Object[reader.FieldCount];
            reader.GetValues(values);

            int i = 0;
            foreach (var prop in obj.GetType().GetProperties()) {
                if (values.Length < i + 1) break;
                prop.SetValue(obj, values[i], null);
                i++;
            }

            reader.Close();
            
            return obj;

        }

        public static int update<T>(T entity) {

            String tablename = (String)typeof(T).GetField("TableName").GetValue(null);

            if (tablename == null) throw new Exception("Type " + typeof(T) + "has no static field named TableName.");

            if (_sqlCon == null) throw new Exception("Must call connect() before calling any DAO's method.");

            if(_sqlCon.State == ConnectionState.Closed) _sqlCon.Open();

            string query = "UPDATE " + tablename;
            string set = " SET ";

            var props = entity.GetType().GetProperties();

            foreach (var prop in props) {

                if (prop.GetValue(entity) == null || prop.GetValue(entity).Equals("")) continue;
                if (String.Equals(prop.Name, "Id")) continue; //not updating Id
                    
                set += prop.Name + "=";

                if (String.Equals(prop.PropertyType.Name, "Boolean")) {
                    if ((bool)prop.GetValue(entity)) {
                        set += 1 + ", ";
                    }
                    else{
                        set += 0 + ", ";
                    }
                }
                else if (String.Equals(prop.PropertyType.Name, "String")) {
                    set += "'" + prop.GetValue(entity) + "'" + ", ";
                }
                else {
                    set += prop.GetValue(entity) + ", ";
                }

            }

            set = set.Substring(0, set.Length - 2); //borra la ultima ", "

            query += set;

            query += " WHERE Id = " + entity.GetType().GetProperty("Id").GetValue(entity);

            SqlCommand command = new SqlCommand(query, _sqlCon);
            int rowsAffected = command.ExecuteNonQuery();

            return rowsAffected;

        }

        public static int insert<T>(T entity) {

            String tablename = (String)typeof(T).GetField("TableName").GetValue(null);

            if (tablename == null) throw new Exception("Type " + typeof(T) + "has no static field named TableName.");

            if (_sqlCon == null) throw new Exception("Must call connect() before calling any DAO's method.");

            if (_sqlCon.State == ConnectionState.Closed) _sqlCon.Open();

            string query = "INSERT INTO " + tablename + " (";
            string queryValues = "VALUES (";

            var props = entity.GetType().GetProperties();

            foreach (var prop in props) {

                if (prop.GetValue(entity) == null || prop.GetValue(entity).Equals("")) continue;
                if (String.Equals(prop.Name, "Id")) continue; //not updating Id

                query += prop.Name + ",";

                if (String.Equals(prop.PropertyType.Name, "Boolean")) {
                    if ((bool)prop.GetValue(entity)) {
                        queryValues += 1 + ", ";
                    }
                    else {
                        queryValues += 0 + ", ";
                    }
                }
                else if (String.Equals(prop.PropertyType.Name, "String"))
                    queryValues += "'" + prop.GetValue(entity) + "'" + ", ";
                else
                    queryValues += prop.GetValue(entity) + ", ";
            }

            query = query.Substring(0, query.Length - 1);
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


    }
}

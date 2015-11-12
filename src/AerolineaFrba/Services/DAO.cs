using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using AerolineaFrba.Config;

namespace AerolineaFrba.Services {

    public static class DAO {

        public static SqlConnection _sqlCon { get; set; }
        private static string _direccion;
        private static string _database;
        private static string _username;
        private static string _password;
        private static string _strCon;

        private static String[] ignoredTypes = {"Aeronave", "BajaAeronave", "Butaca", "Cancelacion", "Canje", "Catalogo",
                                                "Ciudad", "Cliente", "Funcionalidad", "Paquete", "Pasaje", "Rol", "Ruta",
                                                "TipoBaja", "TipoServicio", "Usuario", "Viaje"
                                               };
        
        static public Exception exception;

        public static void connect() { //default connection
            _direccion = DBConfig.direccion;
            _database = DBConfig.database;
            _username = DBConfig.username;
            _password = DBConfig.password;

            _strCon = makeConnectionString(_direccion, _database, _username, _password);
            _sqlCon = new SqlConnection(_strCon);
        }

        public static void connect(string direccion, string database, string username, string password) { //custom connection
            _direccion = direccion;
            _database  = database;
            _username  = username;
            _password  = password;

            _strCon = makeConnectionString(_direccion, _database, _username, _password);
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

            SqlCommand command = Select(typeof(T), filters);

            T obj = new T();

            SqlDataReader reader = command.ExecuteReader();

            if (!reader.HasRows) return default(T);

            reader.Read();
            Object[] values = new Object[reader.FieldCount];
            reader.GetValues(values);

            int i = 0;
            foreach (var prop in obj.GetType().GetProperties()) {
                
                if (ignoredTypes.Contains(prop.PropertyType.Name)) continue; //ignore model types (lazy load)
                
                if (values.Length < i + 1) break;

                if (values[i] == System.DBNull.Value) {

                    if (prop.PropertyType.Name.Equals("Int32")) {
                        prop.SetValue(obj, 0, null);
                    }

                    if (prop.PropertyType.Name.Equals("String")) {
                        prop.SetValue(obj, "", null);
                    }

                }
                else {
                    prop.SetValue(obj, values[i], null);
                }

                i++;

            }

            reader.Close();
            
            return obj;

        }


        /* 
         * PARA QUE FUNCIONE BIEN, LOS ATRIBUTOS DE LOS OBJ TIENEN QUE ESTAR EN EL MISMO ORDEN QUE LAS COLUMNAS EN LAS TABLAS,
         * ATRIBUTOS DE TABLAS INTERMEDIAS Y ATRIBUTOS EXTRA AL FINAL
         */
        public static List<T> selectAll<T>(String[] filters) where T : new() {

            SqlCommand command = Select(typeof(T), filters);

            List<T> obj_list = new List<T>();
            
            SqlDataReader reader = command.ExecuteReader();

            if (!reader.HasRows) return obj_list;

            while (reader.Read()) {

                T obj = new T();

                Object[] values = new Object[reader.FieldCount];
                reader.GetValues(values);

                int i = 0;
                foreach (var prop in obj.GetType().GetProperties()) {

                    if (ignoredTypes.Contains(prop.PropertyType.Name)) continue; //ignore model types (lazy load)

                    if (values.Length < i + 1) break;

                    if (values[i] == System.DBNull.Value) {

                        if (prop.PropertyType.Name.Equals("Int32")) {
                            prop.SetValue(obj, 0, null);
                        }

                        if (prop.PropertyType.Name.Equals("String")) {
                            prop.SetValue(obj, "", null);
                        }

                    }
                    else {
                        prop.SetValue(obj, values[i], null);
                    }

                    i++;

                }

                obj_list.Add(obj);

            }
            
            reader.Close();

            return obj_list;

        }

        public static int update<T>(T entity) {

            String tablename = (String)typeof(T).GetField("TableName").GetValue(null);

            if (tablename == null) throw new Exception("Type " + typeof(T) + "has no static field named TableName.");

            if (_sqlCon == null) throw new Exception("Must call connect() before calling any DAO's method.");

            string query = "UPDATE " + tablename;
            string set = " SET ";

            var props = entity.GetType().GetProperties();

            foreach (var prop in props) {

                if (prop.GetValue(entity) == null || prop.GetValue(entity).Equals("")) continue;
                if (String.Equals(prop.Name, "Id")) continue; //not updating Id
                if (ignoredTypes.Contains(prop.PropertyType.Name)) continue; //ignore model types (lazy load)
                    
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
                else if (String.Equals(prop.PropertyType.Name, "DateTime")) {
                    DateTime date = (DateTime)prop.GetValue(entity);
                    set += "'" + date.ToString("yyyy-MM-dd HH:mm:ss") + "'" + ", ";
                }
                else if (String.Equals(prop.PropertyType.Name, "Decimal"))
                {
                    Decimal numero = (Decimal)prop.GetValue(entity);
                    String numeroS = numero.ToString();
                    numeroS = numeroS.Replace(",", ".");
                    set +=  numeroS + ", ";
                }
                else {
                    set += prop.GetValue(entity) + ", ";
                }

            }

            set = set.Substring(0, set.Length - 2); //borra la ultima ", "

            query += set;

            query += " WHERE Id = " + entity.GetType().GetProperty("Id").GetValue(entity);

            if (_sqlCon.State == ConnectionState.Closed) _sqlCon.Open();

            SqlCommand command = new SqlCommand(query, _sqlCon);
            int rowsAffected = command.ExecuteNonQuery();

            if (rowsAffected == 0) return rowsAffected;
            else return Convert.ToInt32(entity.GetType().GetProperty("Id").GetValue(entity));

        }
        
        public static int insert<T>(T entity) {

            String tablename = (String)typeof(T).GetField("TableName").GetValue(null);

            if (tablename == null) throw new Exception("Type " + typeof(T) + "has no static field named TableName.");

            if (_sqlCon == null) throw new Exception("Must call connect() before calling any DAO's method.");

            string query = "INSERT INTO " + tablename + " (";
            string queryValues = "VALUES (";

            var props = entity.GetType().GetProperties();

            foreach (var prop in props) {

                if (prop.GetValue(entity) == null || prop.GetValue(entity).Equals("")) continue;
                if (String.Equals(prop.Name, "Id")) continue; //not updating Id
                if (ignoredTypes.Contains(prop.PropertyType.Name)) continue; //ignore model types (lazy load)

                query += prop.Name + ",";

                if (String.Equals(prop.PropertyType.Name, "Boolean")) {
                    if ((bool)prop.GetValue(entity)) {
                        queryValues += 1 + ", ";
                    }
                    else {
                        queryValues += 0 + ", ";
                    }
                }
                else if (String.Equals(prop.PropertyType.Name, "String")) {
                    queryValues += "'" + prop.GetValue(entity) + "'" + ", ";
                }
                else if (String.Equals(prop.PropertyType.Name, "DateTime")) {
                    DateTime date = (DateTime)prop.GetValue(entity);
                    if (date.Day == 1 && date.Month == 1 && date.Year == 1) queryValues += "null" + ", ";
                    else queryValues += "'" + date.ToString("yyyyMMdd HH:mm:ss") + "'" + ", ";
                }
                else if (String.Equals(prop.PropertyType.Name, "Decimal"))
                {
                    Decimal numero = (Decimal)prop.GetValue(entity);
                    String numeroS = numero.ToString();
                    numeroS = numeroS.Replace(",", ".");
                    queryValues += numeroS + ", ";
                }
                else
                    queryValues += prop.GetValue(entity) + ", ";
            }

            query = query.Substring(0, query.Length - 1);
            queryValues = queryValues.Substring(0, queryValues.Length - 2);

            query += ") ";
            queryValues += ")";

            query += queryValues;
            query += "; SELECT SCOPE_IDENTITY();"; //Devuelve el Last Inserted ID

            if (_sqlCon.State == ConnectionState.Closed) _sqlCon.Open();
            
            SqlCommand command = new SqlCommand(query, _sqlCon);
            //bool insertado = false;
            object lastInsertedId = command.ExecuteScalar();;

            if (!Convert.ToBoolean(lastInsertedId)) return 0;

            return Convert.ToInt32(lastInsertedId); // Devuelve el last insert ID o 0 en caso de falla.
        }

        public static string makeConnectionString() {
            return "Data Source=" + DBConfig.direccion + ";Initial Catalog=" +
                     DBConfig.database + ";User ID=" + DBConfig.username + ";Password=" + DBConfig.password + ";" + "MultipleActiveResultSets=True;";
        }

        public static string makeConnectionString(string direccion, string database, string username, string password){
             return "Data Source=" + direccion + ";Initial Catalog=" +
                     database + ";User ID=" + username + ";Password=" + password + ";" + "MultipleActiveResultSets=True;";
        }



        private static SqlCommand Select(Type T, String[] Filters){

            String tablename = (String)T.GetField("TableName").GetValue(null);

            if (tablename == null) throw new Exception("Type " + T + "has no static field named TableName.");

            if (_sqlCon == null) throw new Exception("Must call connect() before calling any DAO's method.");

            if (_sqlCon.State == ConnectionState.Closed) _sqlCon.Open();

            string query = "SELECT * FROM " + tablename;

            if (Filters != null && Filters.Length != 0) {

                query += " WHERE ";

                foreach (String where in Filters) {
                    query += where;
                    query += " AND ";
                }

                query = query.Substring(0, query.Length - 5); //saca el ultimo 'and'

            }

            return new SqlCommand(query, _sqlCon);
            
        }
      
    }
}

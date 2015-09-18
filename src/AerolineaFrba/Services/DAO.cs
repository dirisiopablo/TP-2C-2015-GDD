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

        static private SqlConnection _sqlCon;
        static private string _direccion;
        static private string _database;
        static private string _username;
        static private string _password;
        static private string _strCon;
        
        static public Exception exception;

        static public void connect() {
            _direccion = DBConfig.direccion;
            _database = DBConfig.database;
            _username = DBConfig.username;
            _password = DBConfig.password;

            _strCon = makeStringConnection(_direccion, _database, _username, _password);
            _sqlCon = new SqlConnection(_strCon);
        }

        static public void connect(string direccion, string database, string username, string password){
            _direccion = direccion;
            _database  = database;
            _username  = username;
            _password  = password;

            _strCon = makeStringConnection(_direccion, _database, _username, _password);
            _sqlCon = new SqlConnection(_strCon);
        }

        static public DataTable select(string tableName) {

            _sqlCon.Open();
            string query = "SELECT * FROM "+ tableName;
            SqlCommand command = new SqlCommand(query, _sqlCon);

            DataTable datatable = new DataTable();

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(datatable);
            adapter.Dispose();

            return datatable;
        }

        static public List<T> select<T>(string tableName) {

            DataTable dt = select(tableName);

            List<T> list = new List<T>();

            //foreach (DataRow dr in dt.Rows)
            //    list.Add(new T().setData(dr));

            return list;
        }

        static public int save<T>(T entity, string TableName) {
            
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


        static private string makeStringConnection(string direccion, string database, string username, string password){
             return "Data Source=" + direccion + ";Initial Catalog=" +
                     database + ";User ID=" + username + ";Password=" + password + ";";
        }

    }
}

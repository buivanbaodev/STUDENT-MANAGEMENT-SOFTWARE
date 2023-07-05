using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public class DatabaseService
    {

        public const string connectString = @"Data Source=DESKTOP-MIE6OUS;Initial Catalog=MCV1;User ID=sa;Password=123456";
        public SqlConnection connection;
        public SqlCommand command;

        public DatabaseService()
        {
            connection = new SqlConnection(connectString);
        }
        public void OpenConnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void CloseConnect()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public SqlDataReader ReadData(string sql)
        {
            command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = sql;
            command.Connection = connection;
            OpenConnect();
            SqlDataReader reader = command.ExecuteReader();
            return reader;
        }
        public SqlDataReader ReadDataPars(string sql, SqlParameter[] pars)
        {
            command = new SqlCommand();
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = sql;
            command.Connection = connection;
            OpenConnect();
            command.Parameters.AddRange(pars);
            SqlDataReader reader = command.ExecuteReader();
            return reader;

        }
        public SqlDataReader WriteData(string sql, SqlParameter[] pars)
        {
            {
                command = new SqlCommand();
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = sql;
                command.Connection = connection;
                OpenConnect();
                command.Parameters.AddWithValue("@Password", "");
                var rows = command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();
                return reader;
            }
        }
    }
}
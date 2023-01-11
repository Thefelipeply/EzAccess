using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GUI
{
    internal class EzAccess
    {

        public String connectionString = null;
        public SqlConnection sql_connection;
        public SqlCommand sql_command;
        public DataSet sql_dataset;
        public SqlDataAdapter sql_dataadapter;
        public string sql = null;

        public void connString()
        {
            sql_connection = new SqlConnection();
            connectionString = "Data Source = LAPTOP-JB4HI8UE; Initial Catalog = EzAccessDB; user id = EZadmin; password = EZmalakas";
            sql_connection = new SqlConnection(connectionString);
            sql_connection.ConnectionString = connectionString;
            sql_connection.Open();
        }
        
        public void cmd()
        {
            sql_command = new SqlCommand(sql, sql_connection);
            sql_command.CommandType = CommandType.Text;
        }

        public void sqladapterSelect()
        {
            sql_dataadapter = new SqlDataAdapter();
            sql_dataadapter.SelectCommand = sql_command;
            sql_command.ExecuteNonQuery();
        }

        public void sqladapterInsert()
        {
            sql_dataadapter = new SqlDataAdapter();
            sql_dataadapter.InsertCommand = sql_command;
            sql_command.ExecuteNonQuery();
        }

        public void sqladapterDelete()
        {
            sql_dataadapter = new SqlDataAdapter();
            sql_dataadapter.DeleteCommand = sql_command;
            sql_command.ExecuteNonQuery();
        }

        public void sqladapterUpdate()
        {
            sql_dataadapter = new SqlDataAdapter();
            sql_dataadapter.UpdateCommand = sql_command;
            sql_command.ExecuteNonQuery();
        }

        public void sqlDataSetSelect_UserTable()
        {
            sql_dataset = new DataSet();
            sql_dataadapter.Fill(sql_dataset, "UserTable");
        }

        public void sqlDataSetSelect_LoginTable()
        {
            sql_dataset = new DataSet();
            sql_dataadapter.Fill(sql_dataset, "LoginTable");
        }

        public void sqlDataSetSelect_LogsTable()
        {
            sql_dataset = new DataSet();
            sql_dataadapter.Fill(sql_dataset, "LogsTable");
        }

        public void UserSelect()
        {
            sql = "SELECT * FROM UserTable";
        }

        public void LoginSelect()
        {
            sql = "SELECT * FROM LoginTable";
        }
        public void LogsSelect()
        {
            sql = "SELECT * FROM LogsTable";
        }


    }
}

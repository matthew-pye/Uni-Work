using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace DataBase
{
    class DBConnector
    {
        private OleDbConnection conn;
        private OleDbCommand cmd;
        private OleDbDataReader dr;
        private string connection;
        private string sql;

        public DBConnector(string path, string dbname, string SQL)
        {
            connection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + path + @"\" + dbname;
            sql = SQL;
        }

        public bool CloseDB()
        {
            try
            {
                conn.Close();
            }
            catch (Exception e)
            {
                return false;
            }

            return true;
        }

        public string GetField()
        {
            try
            {
                return dr["ID"].ToString() + "        " + dr["Description"].ToString();
            }
            catch (Exception e)
            {
                return "";
            }
        }

        public void NextRecord()
        {
            try
            {
                dr.Read();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                CloseDB();
                OpenConnection();
            }
           
        }

        public void OpenConnection()
        {
            conn = new OleDbConnection(connection);
            conn.Open();
            cmd = new OleDbCommand(sql, conn);
            dr = cmd.ExecuteReader();
        }
    }
}

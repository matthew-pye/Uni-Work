using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string connection = "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + Application.StartupPath + @"\Test.accdb"; string sql = "SELECT * FROM Part";
            try
            {

                OleDbConnection conn = new OleDbConnection(connection);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand(sql, conn);
                OleDbDataReader dr = cmd.ExecuteReader();
                dr.Read();
                Console.Write("ID:{0} Description:{1} ", dr["ID"].ToString(), dr["Description"].ToString());
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());

            }
        }


    }
}

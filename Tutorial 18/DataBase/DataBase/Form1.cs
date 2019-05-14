using System;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Form1 : Form
    {
        private DBConnector dbc;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dbc = new DBConnector(Application.StartupPath.ToString(), "test.accdb", "SELECT * FROM Part");
            dbc.OpenConnection();
        }

        private void NextRecordbtn_Click(object sender, EventArgs e)
        {
            dbc.NextRecord();
            Recordlbl.Text = dbc.GetField();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbc.CloseDB();
        }
    }
}
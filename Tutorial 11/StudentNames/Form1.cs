using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentNames
{
    public partial class Form1 : Form
    {
        static FileStream Output = new FileStream("Output.txt", FileMode.Create);
        StreamWriter swOut = new StreamWriter(Output);

        public Form1()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            swOut.WriteLine("{0} \t {1}",FirstName.Text, SecondName.Text);
            FirstName.Text = "";
            SecondName.Text = "";
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            Output.Close();
            Environment.Exit(1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            swOut.WriteLine("First Name \t Second Name");
        }
    }
}

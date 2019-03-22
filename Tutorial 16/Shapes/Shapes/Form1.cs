using System;
using System.Windows.Forms;

namespace Shapes
{
    public partial class Form1 : Form
    {
        private Triangle Tri;
        private Rectangle Rec;
        private Circle Circ;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Tri = new Triangle(3, 2);
            Rec = new Rectangle(4, 6);
            Circ = new Circle(10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Circ.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Tri.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = Rec.ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaseUnit
{
    public partial class Form1 : Form
    {
        private BaseUnit BU;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BU = new BaseUnit(
                                new GraphicsCard("GTX 1060", 3000),
                                new Motherboard("Gigabyte", "SOC-Force"),
                                new PowerSupply(1000),
                                new Processor("i7 4770k", 4.4f)
                             );

            BU.AddRAM(new RAMemory(RAMType.DDR3, 1333));
            BU.AddRAM(new RAMemory(RAMType.DDR3, 1333));
            BU.AddRAM(new RAMemory(RAMType.DDR3, 1333));
            BU.AddRAM(new RAMemory(RAMType.DDR3, 1333));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = BU.ToString();
        }
    }
}

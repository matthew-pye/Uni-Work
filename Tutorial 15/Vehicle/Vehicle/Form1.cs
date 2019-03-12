using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehicle V = new Vehicle();

            Bicycle Bike = new Bicycle(true,"Red",21);
            BicycleLabel.Text = Bike.ToString();

            MotorBike MBike = new MotorBike("Green", 1600, "Fork");
            MotorBikeLabel.Text = MBike.ToString();

            Car C = new Car("Red", 2000, 5);
            CarLabel.Text = C.ToString();

            Total.Text = "There are " + Convert.ToString(V.GetCount()) + "Vehicles";
        }
    }
}

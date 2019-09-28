using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _test_project01_cowsAndFarmers02
{
    public partial class Form1 : Form
    {
        Farmer farmer;
        public Form1()
        {
            InitializeComponent();
            farmer = new Farmer(15, 30);
            numericUpDown1.Value = farmer.NumberOfCows;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            farmer.NumberOfCows = (int)numericUpDown1.Value;
        }

        private void button_calculate_Click(object sender, EventArgs e)
        {
            Console.WriteLine("For cows {0} we need {1} amount of bags",farmer.NumberOfCows, farmer.BagsOfFeed );
        }


    }
}

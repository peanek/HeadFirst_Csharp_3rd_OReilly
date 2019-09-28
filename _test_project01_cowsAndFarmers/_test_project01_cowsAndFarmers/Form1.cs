using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _test_project01_cowsAndFarmers
{
    public partial class Form1 : Form
    {
        Farmer farmer;
        public Form1()
        {
            InitializeComponent();
            farmer = new Farmer((int)numericUpDown1.Value, 30);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            farmer.CowsNumber = (int)numericUpDown1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bags = farmer.Bags;
            Console.WriteLine("For {0} cows I need {1} bags", farmer.CowsNumber, farmer.Bags);
        }

    }
}

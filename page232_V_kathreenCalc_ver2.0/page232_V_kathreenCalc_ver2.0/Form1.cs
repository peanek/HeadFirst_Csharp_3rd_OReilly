using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace page232_V_kathreenCalc_ver2._0
{
    public partial class Form1 : Form
    {
        DinnerParty dinner;
        public Form1()
        {
            InitializeComponent();
            dinner = new DinnerParty((int)numericUpDown1.Value, checkBox1.Checked, checkBox2.Checked);
            DisplayPartyCost();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DisplayPartyCost()
        {
            //decimal cost = dinner.Cost;
            label1.Text = dinner.Cost.ToString("c");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinner.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayPartyCost();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dinner.FancyDecorations = checkBox1.Checked;
            DisplayPartyCost();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dinner.HealthyFood = checkBox2.Checked;
            DisplayPartyCost();
        }

    }
}

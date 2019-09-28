using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace page240_VI_CathreenCalc_ver2._1
{
    public partial class Form1 : Form
    {
        DinnerParty dinner;
        BirthdayParty birthday;
        public Form1()
        {
            InitializeComponent();
            numericUpDown1.Value = 5;
            dinner = new DinnerParty((int)numericUpDown1.Value, checkBox1.Checked, checkBox2.Checked);
            DisplayCostMethod();
            birthday = new BirthdayParty((int)numerBirthday.Value, fancyBirthday.Checked, textBox1.Text);
            tooLongLabel.Visible = false;

        }
        public void DisplayCostMethod()
        {
            decimal Cost = dinner.Cost;
            label1.Text = Cost.ToString("c");
        }

        public void DisplayBirthdayPartyCostMethon()
        {
            tooLongLabel.Visible = birthday.CakeWritingTooLong;
            textBox2.Text = birthday.Cost.ToString("c");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinner.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayCostMethod();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            dinner.FancyDecorations = checkBox1.Checked;
            DisplayCostMethod();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            dinner.HealthyOption = checkBox2.Checked;
            DisplayCostMethod();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void numerBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthday.NumberOfPeople = (int)numerBirthday.Value;
            DisplayBirthdayPartyCostMethon();
        }

        private void fancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthday.FancyDecorations = fancyBirthday.Checked;
            DisplayBirthdayPartyCostMethon();

        }

        private void tooLongLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            birthday.CakeWriting = textBox1.Text;
            DisplayBirthdayPartyCostMethon();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

    }
}

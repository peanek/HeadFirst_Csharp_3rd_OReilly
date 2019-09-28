using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace page279_VI_queens
{
    public partial class Form1 : Form
    {
        Queen queen;


        public Form1()
        {
            InitializeComponent();
            Worker[] workers = new Worker[4];
            comboBoxJobsToDo.SelectedIndex = 0;

            workers[0] = new Worker(new string[] {"Nectar collector", "Honey manufacturing" });
            workers[1] = new Worker(new string[] {"Egg care", "Baby bee tutoring" });
            workers[2] = new Worker(new string[] { "Hive maintenance", "Sting patrol" });
            workers[3] = new Worker(new string[] { "Baby bee tutoring", "Egg care", "Hive maintenance", "Honey manufacturing", "Nectar collector", "Sting patrol"});
            queen = new Queen(workers);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAssignTheJobToABee_Click(object sender, EventArgs e)
        {
            if (numericUpDownShifts.Value!=0)
            {
                string text = comboBoxJobsToDo.Text;
                int shift = Convert.ToInt32(numericUpDownShifts.Value);
                queen.AssignWork(text,shift);

            }
            else
            {
                textBoxReport.Text = "Shift number must be different than 0 !!!!";
            }
        }

        private void buttonWorkTheNextShift_Click(object sender, EventArgs e)
        {
            textBoxReport.Text = queen.WorkTheNextShift().ToString();
        }
    }
}

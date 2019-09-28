using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace str170_III_joeyBob_stageSekonddd
{
    public partial class Form1 : Form
    {
        gej joey = new gej() { Cash = 50, Name = "Joey" };
        gej bob = new gej() {Cash = 100, Name = "Bob"};
        int bank = 100;

        public Form1()
        {
            
            InitializeComponent();
            updateForm();
            
            button1.Text = "joey gives 10 to bank";
            button2.Text = "bob gives 5 to joey";
            
        }

        public void updateForm()
        {
            label1.Text = joey.Name + " has money " + joey.Cash;
            label2.Text = bob.Name + " has money " + bob.Cash;
            label3.Text = "Bank has money " + bank;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (joey.Cash>=10)
            {
                bank += joey.giveCash(10);
                updateForm();
            }
            else
            {
                MessageBox.Show("JOEY has not enought money.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (bob.Cash>=5)
            {
                joey.receiveMoney(bob.giveCash(5));
                updateForm();
            }
            else
            {
                MessageBox.Show("BOB has not enought money.");
            }
        }
    }
}

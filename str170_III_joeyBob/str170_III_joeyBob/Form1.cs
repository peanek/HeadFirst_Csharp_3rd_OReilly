using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace str170_III_joeyBob
{
    public partial class Form1 : Form
    {
        Guy joe = new Guy() { Cash = 50, Name = "joe" };
        Guy bob = new Guy() { Cash = 100, Name = "bob" };
        int bank = 100;


        public void updateForm()
        {
            joeyLabel.Text = joe.Name + " has right now " + joe.Cash + "zł";
            bobLabel.Text = bob.Name + " has right now " + bob.Cash + "zł";
            bankLabel.Text = "Bank has" + bank + "zł";
            

        }


        public Form1()
        {
            InitializeComponent();
            give10Joey.Text = "give10Joey";
            take5fromBob.Text = "take5fromBob";
            bobGives5toJoey.Text = "bob Gives 5toJoey";
            joeGives10toBob.Text = "joe Gives 10toBob";
            //bob = new Guy();
            ////joe = new Guy();
            //bob.Cash = 100;
            //joe.Cash = 50;
            //bob.Name = "Bob";
            //joe.Name = "Joey";
            updateForm();
        }



        private void give10Joey_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.receiveCash(10);
                updateForm();
            }
            else
            {
                MessageBox.Show("Bank has not enough money !!");
            }

        }

        private void take5fromBob_Click(object sender, EventArgs e)
        {

            bank += bob.giveCash(5);
            updateForm();
        }

        private void joeGives10toBob_Click(object sender, EventArgs e)
        {
            if (joe.Cash>=10)
            {
                joe.giveCash(10);
                bob.receiveCash(10);
                updateForm();
            }
            else
            {
                MessageBox.Show("Joey has not enough money, poor motherfucker...");
            }
           
        }

        private void bobGives5toJoey_Click(object sender, EventArgs e)
        {
            if (this.bob.Cash>=5)
            {
                this.bob.giveCash(5);
                this.joe.receiveCash(5);
                updateForm();
            }
            else
            {
                MessageBox.Show("Bob has not enough money, poor motherfucker...");
            }
        }


    }
}

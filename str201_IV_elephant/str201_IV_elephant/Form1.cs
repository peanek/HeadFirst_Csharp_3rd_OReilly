using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace str201_IV_elephant
{
    public partial class Form1 : Form
    {
        Elephant llucinda;
        Elephant lloyd;
 
        public Form1()
        {
            InitializeComponent();
            llucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            lloyd = new Elephant() { Name = "Loyd", EarSize = 40 }; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loyd_Click(object sender, EventArgs e)
        {
            lloyd.whoAmI();
        }

        private void lucinda_Click(object sender, EventArgs e)
        {
            llucinda.whoAmI();
        }

        private void change_Click(object sender, EventArgs e)
        {
            
            //Elephant holder2;
            Elephant holder1;
            holder1= lloyd;
            lloyd = llucinda;
            llucinda = holder1;
            MessageBox.Show("Object Changes");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}

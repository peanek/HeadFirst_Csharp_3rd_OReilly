using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace str219_IV_labelsHimself
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }
        LabelBouncer[] bouncers = new LabelBouncer[3];

        private void Form1_Load(object sender, EventArgs e)
        {
            //timer1.Enabled = true;
        }

        private void toogleBoucing(int index, Label labelToBouncer)
        {
            if (bouncers[index] == null)
            {
                bouncers[index] = new LabelBouncer();
                bouncers[index].MyLabel = labelToBouncer;
            }
            else
            {
                bouncers[index] = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            toogleBoucing(0, label1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            toogleBoucing(1, label2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            toogleBoucing(2, label3);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                if (bouncers[i] != null)
                {
                    bouncers[i].Move();
                }
            }
        }
    }
}

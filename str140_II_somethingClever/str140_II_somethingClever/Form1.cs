using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace str140_II_somethingClever
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (Visible)
            {
                for (int c = 0; c < 255 && Visible; c++)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                }
                for (int d = 255; d > 0 && Visible; d--)
                {
                    this.BackColor = Color.FromArgb(d, 255 - d, d);
                    Application.DoEvents();
                    System.Threading.Thread.Sleep(3);
                }     
            }
           
        }
    }
}

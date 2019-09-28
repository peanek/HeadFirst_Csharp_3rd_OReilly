using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace str207_IV_ManuMaker
{
    public partial class Form1 : Form
    {
        ManuMaker menu = new ManuMaker() { Randomizer = new Random() };
        public Form1()
        {
            
            InitializeComponent();

            label1.Text = menu.GetMenuItem();
            label2.Text = menu.GetMenuItem();
            label3.Text = menu.GetMenuItem();
            label4.Text = menu.GetMenuItem();
            label5.Text = menu.GetMenuItem();
            label6.Text = menu.GetMenuItem();

        }
    }
}

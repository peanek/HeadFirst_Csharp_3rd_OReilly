using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace str130_II_4_windowsFroms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void changeText_Click(object sender, EventArgs e)
        {
            if (enableCheckBox.Checked == false)
            {
                labelToChange.Text = "check box needs to be ENABLED !!";
            }

            else
            {
                if (labelToChange.Text.Equals("LEFT"))
                {
                    labelToChange.Text = "RIGHT";
                    labelToChange.TextAlign = ContentAlignment.MiddleLeft;
                }
                else
                {
                    labelToChange.Text = "LEFT";
                    labelToChange.TextAlign = ContentAlignment.MiddleRight;
                }
            }
        }

        private void enableCheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void labelToChange_Click(object sender, EventArgs e)
        {

        }

    }
}

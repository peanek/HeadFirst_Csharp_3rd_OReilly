using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _page89_II_MyDesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox_EnableLabelChanging_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_ChangeLabelPosition_Click(object sender, EventArgs e)
        {
            if (checkBox_EnableLabelChanging.Checked)
            {
                if (labelToChange.Text.Equals("RIGHT"))
                {
                    labelToChange.Text = "LEFT";
                    labelToChange.TextAlign = ContentAlignment.MiddleLeft;
                }
               else  if (labelToChange.Text.Equals("LEFT"))
                {
                    labelToChange.Text = "RIGHT";
                    labelToChange.TextAlign = ContentAlignment.MiddleRight;
                }
                else
                {
                    labelToChange.Text = "RIGHT";
                    labelToChange.TextAlign = ContentAlignment.MiddleRight;
                }
            }
            else
            {
                labelToChange.Text = "Text changing is disabled";
                labelToChange.TextAlign = ContentAlignment.MiddleCenter;
            }
        }
    }
}

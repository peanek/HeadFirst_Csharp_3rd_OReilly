using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace str147_II_talker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void doSomethBaton_Click(object sender, EventArgs e)
        {
            int len = Talker.blahBlah(textBox1.Text, (int)numericUpDown1.Value);
            
            MessageBox.Show(""+len);
        }
    }
}

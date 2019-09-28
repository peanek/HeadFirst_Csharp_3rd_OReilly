using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace str209_IV_elephant
{
    public partial class Form1 : Form
    {
        Elephant lloyd = new Elephant() {Name = "Loyd", EarSize = 65 };
        Elephant llucinda = new Elephant() {Name = "Lucinda", EarSize = 70 };
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            //lloyd.TellMe("Dupa", lloyd);
            llucinda.SpeakTo(llucinda,"hello");
        }
    }
}

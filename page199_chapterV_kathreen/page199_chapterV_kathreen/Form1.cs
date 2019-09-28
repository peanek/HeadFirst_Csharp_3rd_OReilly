using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace page199_chapterV_kathreen
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty() { NumberOfPeople = 5 };
            dinnerParty.SetHealthyOption(false);
            dinnerParty.CalculateCostOfDecorations(true);
            DisplyaDinnerPartyCost();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DisplyaDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(checkboxHealthyOption.Checked);
            costLabel.Text = Cost.ToString("f3");
        }

        private void numericPeople_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericPeople.Value;
            DisplyaDinnerPartyCost();
        }

        private void checkboxFancy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxFancy.Checked==false)
            {
                dinnerParty.CalculateCostOfDecorations(false);
                DisplyaDinnerPartyCost();    
            }
            else
            {
                dinnerParty.CalculateCostOfDecorations(true);
                DisplyaDinnerPartyCost();
            }
            
        }

        private void checkboxHealthyOption_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxHealthyOption.Checked==false)
            {
                dinnerParty.SetHealthyOption(false);
                DisplyaDinnerPartyCost();
            }
            else
            {
                dinnerParty.SetHealthyOption(true);
                DisplyaDinnerPartyCost();
            }
        }
    }
}

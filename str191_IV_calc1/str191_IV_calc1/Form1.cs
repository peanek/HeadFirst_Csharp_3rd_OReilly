using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace str191_IV_calc1
{
    public partial class Form1 : Form
    {
        int startingMileage;
        int endingMileage;

        double milesTraveled;
        double reimbursRate = 0.39;
        double amountOwned;

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            startingMileage = (int)beginningNumeric.Value;
            endingMileage = (int)endNumeric.Value;
            if (endingMileage > startingMileage)
            {
                
                milesTraveled = endingMileage - startingMileage;
                amountOwned = milesTraveled * reimbursRate;
                moneyToRecover.Text = amountOwned.ToString() + "money"; 

            }
            else
            {
                MessageBox.Show("Not enouth money", "ERROR !!!");
            
            }


        }

        private void kmMessageBox_Click(object sender, EventArgs e)
        {
            MessageBox.Show(milesTraveled+" km made","KM MADE!!");
        }
    }
}

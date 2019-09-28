using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace str170_III_joeyBob_stageSekonddd
{
    class gej
    {
        public string Name;
        public int Cash;

        public string ToString()
        {
            return Name + " has this money " + Cash;
        }

        public int giveCash(int amount)
        {
            if (amount <= Cash && amount>0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show(Name+" has noot so many good la bla bla");
                return 0;
            }

        }

        public int receiveMoney(int amount)
        {
            if (amount>0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(amount + " it is not so much to receive");
                return 0;
            }
        }

    }
}

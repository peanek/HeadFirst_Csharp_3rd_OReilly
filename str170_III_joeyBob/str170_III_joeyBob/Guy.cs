using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace str170_III_joeyBob
{

    class Guy
    {
        /// <summary>
        /// 
        /// </summary>
        public string Name;
        /// <summary>
        /// 
        /// </summary>
        public int Cash;


        public int giveCash(int amount) 
        {
            if (amount <= Cash && amount > 0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show("Dunno have amount of "+amount+" dear "+this.Name);
                return 0;
            }
        }

        public int receiveCash(int amount)
        {
            if (amount > 0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show("You want to make a shit of me, dear "+Name+" at money of "+amount);
                return 0;
            }

        }
    }
}

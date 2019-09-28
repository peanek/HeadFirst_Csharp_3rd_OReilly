using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_PROJECT
{
    class GumballMachine
    {
        private int gumballs;
        private int price;
        public int Price
        {
            get
            {
                return price;
            }
            private set
            {
                price = value;
            }
        }

        public GumballMachine(int gumballs, int price)
        {
            this.gumballs = gumballs;
            Price = price;
        }

        public string DispenseOneGumball(int price, int coinsInserted)
        {
            if (coinsInserted >= price)
            {
                gumballs--;
                return "Here is your gumball";
            }
            else
            {
                return "You need to put more coins";
            }
        }

    }
}

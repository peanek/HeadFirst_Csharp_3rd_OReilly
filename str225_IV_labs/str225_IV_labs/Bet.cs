using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace str225_IV_labs
{
    public class Bet
    {
        public int Amount;
        public int Dog;
        public Guy Bettor;

        public string GetDescription()
        {
            if (Amount==0)
            {
                return Bettor.Name + " did not made any bet !!";
            }
            else
            {
                return Bettor.Name + " made a bet for " + Amount + "$ and for dog no. "+Dog;
            }
        }

        public int PayOut(int Winner)
        {
            if (Winner == Bettor.MyBet.Dog)
            {
                return Bettor.Cash += Bettor.MyBet.Amount;

            }
            else if ( Winner != Bettor.MyBet.Dog)
            {
                return Bettor.Cash -= Bettor.MyBet.Amount;

            }
            return 1;
        }

    }
}

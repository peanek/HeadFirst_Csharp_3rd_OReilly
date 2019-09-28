using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace str225_IV_labs
{
    public class Guy
    {
        public string Name;
        public Bet MyBet;
        public int Cash;
        public RadioButton MyRadioButton;
        public Label MyLabel;

        public void UpdateLabels()
        {

        }

        public bool PlaceBet(int Amount, int DogToWin)
        {
            if (Amount <= Cash)
            {
                MyBet = new Bet() { Amount = Amount, Dog = DogToWin, Bettor = this };
                return true;
            }
            else
            {
                return false;
            }

        }

        public void ClearBet()
        {
            MyBet.Amount = 0;
            MyBet.Dog = 0;
        }

        public void Collect(int Winner)
        {

            MyBet.PayOut(Winner);

        }
    }
}

using page274_VI_kathreenCalc_ver2._5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page240_VI_CathreenCalc_ver2._5
{
    class DinnerParty : Party
    {
        public bool HealthyOption { get; set; }

        public DinnerParty(int numberofPeople, bool fancyDecorations, bool healthyOption )
        {
            this.NumberOfPeople = numberofPeople;
            this.HealthyOption= healthyOption;
            this.FancyDecorations = fancyDecorations;
        }
        override public decimal Cost
        {
            get
            {
                decimal finalCost = base.Cost;
                finalCost += CalculateBeveragesPerPerson(HealthyOption, NumberOfPeople);
                if (HealthyOption)
                {
                    return finalCost * 0.95M;
                }
                return finalCost;
            }
        }

        private decimal CalculateBeveragesPerPerson(bool healthy, int numberOfPeople)
        {
            if (healthy)
            {
                return (numberOfPeople*5.00M);
            }
            else
            {
                return numberOfPeople * 20.00M;
            }
        }
    }
}

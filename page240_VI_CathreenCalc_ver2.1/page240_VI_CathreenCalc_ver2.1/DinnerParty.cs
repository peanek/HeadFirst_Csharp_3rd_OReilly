using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page240_VI_CathreenCalc_ver2._1
{
    class DinnerParty
    {
        public const int CostPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool HealthyOption { get; set; }
        public bool FancyDecorations { get; set; }

        public DinnerParty(int numberofPeople, bool fancyDecorations, bool healthyOption )
        {
            this.NumberOfPeople = numberofPeople;
            this.HealthyOption= healthyOption;
            this.FancyDecorations = fancyDecorations;
        }
        public decimal Cost
        {
            get
            {
                decimal finalCost;
                finalCost = (NumberOfPeople * 25.00M) + CalculateBeveragesPerPerson(HealthyOption, NumberOfPeople) + CalculateDecorationsPerPerson(FancyDecorations, NumberOfPeople);

                if (HealthyOption)
                {
                    return finalCost * 0.95M;
                }

                if (NumberOfPeople > 12)
                {
                    finalCost += 100;
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

        private decimal CalculateDecorationsPerPerson(bool fancyDecorations, int numberOfPeople)
        {
            if (fancyDecorations)
            {
                return (numberOfPeople * 15.00M) + 50.00M;
            }
            else
            {
                return (numberOfPeople * 7.50M) + 30.00M;
            }
        }
        

    }
}

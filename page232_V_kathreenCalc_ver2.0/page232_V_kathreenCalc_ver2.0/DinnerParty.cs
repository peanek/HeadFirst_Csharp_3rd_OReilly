using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page232_V_kathreenCalc_ver2._0
{
    class DinnerParty
    {
        private const int costPerPerson = 25;
        private int numberOfPeople;
        private bool fancyDecorations;
        private bool healthyFood;
        public decimal Cost
        {
            get
            {
                decimal finalCost = CalculateCostOfDecorations();
                    finalCost += (numberOfPeople * costPerPerson)  + (CalculateCostOfBeveragesPerPerson());
                return finalCost;
            }
        }

        public int NumberOfPeople { 
            get
            {
                return numberOfPeople;
            }
            set
            {
                numberOfPeople = value;
            }

        }
        public bool FancyDecorations { get { return fancyDecorations; } set { fancyDecorations = value; } }
        public bool HealthyFood { get { return healthyFood; } set { healthyFood = value; } }
        //public decimal Cost 
        //{ 
        //    get 
        //    {
        //        return cost;
        //    }
        //    set
        //    {
        //        decimal finalCost;
        //        finalCost = numberOfPeople * 20;
                
        //    }

        //}

        public DinnerParty(int numberOfPeople, bool fancy, bool heathly)
        {
            this.numberOfPeople = numberOfPeople;
            this.fancyDecorations = fancy;
            this.healthyFood = heathly;
        }

        private decimal CalculateCostOfDecorations()
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

        private decimal CalculateCostOfBeveragesPerPerson()
        {
            if (healthyFood)
            {
                return (numberOfPeople * 5.00M) * 0.95M;
            }
            else
            {
                return numberOfPeople * 20.00M;
            }
        }




    }
}

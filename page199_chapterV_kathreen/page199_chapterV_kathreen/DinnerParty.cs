using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page199_chapterV_kathreen
{
    class DinnerParty
    {
        private int NumberOfPeople;
        public decimal CostOfBeveragesPerPerson;
        public decimal CostOfDecorations;

        public const int CostOfFoodPerPerson = 25;

        public void SetHealthyOption(bool healthyOption)
        {
            if (healthyOption)
            {
                CostOfBeveragesPerPerson = 5.00M; 
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }
        }

        public void CalculateCostOfDecorations(bool fancyOption)
        {
            if (fancyOption)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50.00M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30.00M;
            }
        }

        public decimal CalculateCost(bool checkedBox)
        {
            
            decimal cost = (NumberOfPeople*(CostOfFoodPerPerson + CostOfBeveragesPerPerson)) +
                CostOfDecorations;

            if (checkedBox)
            {
                cost *= 0.95M;
                return cost;
            }
            else
            {
                return cost;
            }
        }

        public int GetNumberPeople()
        {
            return NumberOfPeople;
        }

        public void SetPartyOptions(int people, bool fancy)
        {
            NumberOfPeople = people;
            CalculateCostOfDecorations(fancy);
        }




        //internal decimal CalculateCost(bool p)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

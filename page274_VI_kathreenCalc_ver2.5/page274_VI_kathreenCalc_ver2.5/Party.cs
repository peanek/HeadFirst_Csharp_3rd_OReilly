using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page274_VI_kathreenCalc_ver2._5
{
    class Party
    {
        public int NumberOfPeople { get; set; }
        public const int CostPerPerson = 25;
        virtual public bool FancyDecorations { get; set; }

        public decimal Cost
        {
            get
            {
                decimal finalCost;
                finalCost = (NumberOfPeople * CostPerPerson) + CalculateCostOfDecorations();
                if (NumberOfPeople > 12)
                {
                    finalCost += 100;
                }

                return finalCost;
            }
            set { }
        }


        private decimal CalculateCostOfDecorations()
        {
            decimal decorationCost;
            if (FancyDecorations)
                return decorationCost = (NumberOfPeople * 25.00M) + 50.00M;
            else
                return decorationCost = (NumberOfPeople * 7.50M) + 30.00M;
        }

    }
}

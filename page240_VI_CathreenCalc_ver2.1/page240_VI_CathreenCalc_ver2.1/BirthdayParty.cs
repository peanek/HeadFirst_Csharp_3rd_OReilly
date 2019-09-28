using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page240_VI_CathreenCalc_ver2._1
{
    class BirthdayParty
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public string CakeWriting { get; set; }
        
        public bool CakeWritingTooLong {
            get 
            {
                if (CakeWriting.Length > MaxWritingLenght())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        
        private int ActualLenght {
            get
            {
                if (CakeWriting.Length > MaxWritingLenght())
                    return MaxWritingLenght();
                else
                    return CakeWriting.Length;
            }

        }
        public decimal Cost {
            get 
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
                decimal cakeCost;
                if (CakeSize() == 8)
                    cakeCost = 40.00M + ActualLenght * 0.25M;
                else
                    cakeCost = 75.00M + ActualLenght * 0.25M;
                if (NumberOfPeople > 12)
                {
                    cakeCost += 100;
                }
                
                return totalCost + cakeCost;
            }
            private set
            { 
            }
        }

        

        private int CakeSize()
        {
            if (NumberOfPeople <= 4)
                return 8;
            else
                return 16;
        }

        private int MaxWritingLenght()
        {
            if (CakeSize() == 8)
                return 16;
            else
                return 40;
            
        }

        public bool MaxWritingTooLong
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLenght())
                    return true;
                else
                    return false;
            }
        }

        private decimal CalculateCostOfDecorations()
        {
            decimal decorationCost;
            if (FancyDecorations)
            {
                return decorationCost = (NumberOfPeople * 15.00M) + 50.00M;
            }
            else
            {
                return decorationCost = (NumberOfPeople * 7.50M) + 30.00M;
            }
        }



        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }



    }
}

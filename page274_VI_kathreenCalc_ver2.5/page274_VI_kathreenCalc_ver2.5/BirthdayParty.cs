using page274_VI_kathreenCalc_ver2._5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page240_VI_CathreenCalc_ver2._5
{
    class BirthdayParty : Party
    {
        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }
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
        override public decimal Cost {
            get 
            {
                decimal totalCost = base.Cost;
                decimal cakeCost;
                if (CakeSize() == 8)
                    cakeCost = 40.00M + ActualLenght * 0.25M;
                else
                    cakeCost = 75.00M + ActualLenght * 0.25M;
                return totalCost + cakeCost;
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
        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }



    }
}

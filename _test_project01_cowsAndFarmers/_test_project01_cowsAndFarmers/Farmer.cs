using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _test_project01_cowsAndFarmers
{
    class Farmer
    {
        private int cowsNumber;
        public int CowsNumber
        {
            get 
            { 
                return cowsNumber; 
            }  
            set
            {
                cowsNumber = value;
            }  
        }
        private int bagsNumber;
        public int Bags
        { 
            get
            {
                return cowsNumber * feedMultiplier;
            }

        }

        private int feedMultiplier;

        public Farmer(int cowsNumber, int feedMultiplier)
        {
            this.cowsNumber = cowsNumber;
            this.feedMultiplier = feedMultiplier;
        }


    }
}

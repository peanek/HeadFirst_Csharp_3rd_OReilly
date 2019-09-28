using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _test_project01_cowsAndFarmers02
{
    class Farmer
    {


        public int BagsOfFeed { get; private set; }
        
        private int numberOfCows;
        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultipler;
            }
        }
        private int feedMultipler;
        public int FeedMultipler
        { 
            get
            {
                return feedMultipler;
            }
        }

        public int GetCowsNumber()
        {
            return numberOfCows;
        }

        public void SetNumberOfCows(int newNumberCows)
        {
            numberOfCows = newNumberCows;
            BagsOfFeed = numberOfCows * feedMultipler;
        }

        public Farmer(int numberOfCows, int feedMultipler)
        {
            NumberOfCows = numberOfCows;
            this.feedMultipler = feedMultipler;
        
        }
    }
}

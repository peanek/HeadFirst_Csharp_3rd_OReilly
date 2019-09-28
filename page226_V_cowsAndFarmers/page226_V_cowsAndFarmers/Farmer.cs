using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page226_V_cowsAndFarmers
{
    class Farmer
    {
        /// <summary>
        /// Klasa dupy
        /// </summary>
        public int BagsOfFeed { get; private set; }

        private int feedMultipler;
        public int FeedMultipler { get { return feedMultipler; } }

        private int numberOfCows;
        public int NumbersOfCows
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

        public Farmer(int numberOfCows, int feedMultipler)
        {
            this.feedMultipler = feedMultipler;
            this.NumbersOfCows = numberOfCows;
        }



    }
}

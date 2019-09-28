using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page266_VI_jewels
{
    class JewelThief : Locksmith
    {
        private Jewels stolenJewels = null;
          override public void ReturnContents(Jewels safeContents, Owner owner)
        {
            
            stolenJewels = safeContents;
            Console.WriteLine("I am stealing" + stolenJewels.Sparkle());

        }
    }
}

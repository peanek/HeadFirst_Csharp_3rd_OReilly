using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{

            
  class Boat 
        {
            private int length;
            public void setLength(int len)
            {
                length = len;
            }
            public int getLenth()
            {
                return length;
            }
            public string move()
            {
                return "drifft ";  //co tu DAĆ?
            }

        }
        class Rowboat : Boat
        {
            public string rowTheBoat()
            {
                return "stroke natasha";
            }
        }

        class Sailboat : Boat
        {
            public string move()
            {
                return "hoist soil";
            }
        }


}

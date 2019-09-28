using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TEST_PROJECT
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
            public virtual string move()
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
            public override string move()
            {
                return "hoist soil";
            }
        }
}

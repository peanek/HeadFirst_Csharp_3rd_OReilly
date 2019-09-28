using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_PROJECT
{
    class A
    {
        public int ivar = 6;
        public virtual string m1()
        {
            return "A's m1, ";
        }
        public string m2()
        {
            return "A's m2, ";
        }
        public virtual string m3()
        {
            return "A's m3, ";
        }


    }

    class B : A
    {
        public override string m1()
        {
            return "B's m1, ";
        }
    }

    class C : B
    {
        public override string m3()
        {
            return "C's m3, " + (ivar+7);
        }
    }
}

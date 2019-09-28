using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST_PROJECT
{
    class MyBaseClass
    {
        public MyBaseClass(string baseClassNeedsThis)
        {
            System.Windows.Forms.MessageBox.Show("This is the base class : " + baseClassNeedsThis);
        }
    }

    class MySubclass : MyBaseClass 
    {
        public MySubclass(string baseClassNeedsThis, int anotherValue) : base(baseClassNeedsThis)
        {
            
            System.Windows.Forms.MessageBox.Show("This is the subclass : " + baseClassNeedsThis + anotherValue);
        }
 
    }
}

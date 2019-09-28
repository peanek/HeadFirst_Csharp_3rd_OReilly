using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Class1
    {
        public static void Main()
        {
            /* str 263_VI_pool*/

            string xyz = "";
            Boat b1 = new Boat();
            Sailboat b2 = new Sailboat();
            Rowboat b3 = new Rowboat();
            b2.setLength(32);
            xyz += b1.move();
            xyz += b3.move();
            xyz += b2.move();
            System.Windows.Forms.MessageBox.Show(xyz);
        }
    }
}

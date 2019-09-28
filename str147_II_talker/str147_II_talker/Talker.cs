using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace str147_II_talker
{
    class Talker
    {
        public static int blahBlah(string thingToSay, int numberOfTimes) 
        {
            string finalString = "";
            for (int count = 0; count < numberOfTimes; count++)
            {
                finalString += thingToSay + "\n";
            }
            MessageBox.Show(finalString+finalString.Length);
            return finalString.Length;
        }
    }
}

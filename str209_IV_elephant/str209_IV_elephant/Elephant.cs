using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace str209_IV_elephant
{
    class Elephant
    {
        public String Name;
        public int EarSize;

        public void TellMe(string message, Elephant whoSaidIt)
        {
            MessageBox.Show(whoSaidIt.Name + " says" + message);

        }

        public string WhoAmI()
        {
            return Name;

        }

        public void SpeakTo(Elephant WhoToTalkTo, string message)
        {
            WhoToTalkTo.TellMe(message, WhoToTalkTo);
        }
        


    }
}

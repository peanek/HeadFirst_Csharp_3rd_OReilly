using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace str201_IV_elephant
{
    class Elephant
    {
        public string Name;
        public byte EarSize;

        public void whoAmI() 
        {
            MessageBox.Show("My ears has "+EarSize+" cm width",Name+" says...");
        }
    }
}

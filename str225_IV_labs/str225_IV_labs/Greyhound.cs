using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace str225_IV_labs
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox;
        public int Location = 0;
        public Random MyRandom;
        

        public bool Run()
        {

            if (Location >= RacetrackLength)
            {
                return true;
            }

            else
            {
                int move = MyRandom.Next(1,20);
                Location += move;
                MyPictureBox.Left += move;
                return false;
            }
        }

        public void TakingStartingPosition()
        {
            Location = 0;
            MyPictureBox.Left = 0;
        }
    }
}

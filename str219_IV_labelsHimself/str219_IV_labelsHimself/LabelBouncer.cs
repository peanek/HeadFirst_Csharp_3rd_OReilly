using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace str219_IV_labelsHimself
{
    class LabelBouncer
    {
        public Label MyLabel;

        public bool goingForward = true;

        public void Move()
        {
            if (MyLabel != null)
            {
                if (goingForward)
                {
                    MyLabel.Left += 5;
                    if (MyLabel.Left >= MyLabel.Parent.Width - MyLabel.Width)
                    {
                        goingForward = false;
                    }
                }
                else
                {
                    MyLabel.Left -= 5;
                    if (MyLabel.Left <= 0)
                    {
                        goingForward = true;
                    }
                }
            }
        }

    }
}

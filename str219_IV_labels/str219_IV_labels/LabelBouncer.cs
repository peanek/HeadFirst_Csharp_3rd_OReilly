using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace str219_IV_labels
{
    class LabelBouncer
    {
        public Label MyLabel;

        public bool GoinForward = true;

        public void Move()
        {
            if (MyLabel != null)
            {
                if (GoinForward == true)
                {
                    MyLabel.Left += 5;
                    if (MyLabel.Left >= MyLabel.Parent.Width - MyLabel.Width)
                    {
                        GoinForward = false;
                    }
                }
                else
                {
                    MyLabel.Left -= 5;
                    if (MyLabel.Left<=0)
                    {
                        GoinForward = true;
                    }
                }
            }
        }

    }
}

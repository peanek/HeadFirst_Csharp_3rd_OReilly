using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_PROJECT

{
 

    public partial class Form1 : Form
    {
        public Form1()

        {
            InitializeComponent();
            /* page262_VI */
            A a = new A();
            B b = new B();
            C c = new C();
            A a2 = new C();
            string q = "";
            q += a.m1();
            q += b.m2();
            q += c.m3();
            MessageBox.Show(q);


            /* page262_VI */
            
            /* str230_V */
            CableBill cableB = new CableBill(4);
            cableB.Discount = true;
            MessageBox.Show(cableB.CalculateAmount(7).ToString());
            /* str230_IV */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bool[] myArray;
            myArray = new bool[15];
            myArray[4] = true;
            int[] heights;
            heights = new int[5];

            bool[] arr = new bool[5];
            //MessageBox.Show(""+arr.Length); 






        }

        private void button1_Click(object sender, EventArgs e)
        {
            Elephant[] elephants = new Elephant[7];

            elephants[0] = new Elephant() { Name = "Lloyd", EarSize = 40 };
            elephants[1] = new Elephant() { Name = "Lcunda", EarSize = 33 };
            elephants[2] = new Elephant() { Name = "Larry", EarSize = 42 };
            elephants[3] = new Elephant() { Name = "Lucil", EarSize = 32 };
            elephants[4] = new Elephant() { Name = "L", EarSize = 44 };
            elephants[5] = new Elephant() { Name = "La", EarSize = 37 };
            elephants[6] = new Elephant() { Name = "Lar", EarSize = 45 };

            Elephant biggerEars = elephants[0];

            for (int i = 1; i < elephants.Length; i++)
            {
                if (elephants[i].EarSize > biggerEars.EarSize)
                {
                    biggerEars = elephants[i];
                }
            }

            MessageBox.Show(biggerEars.EarSize.ToString());


        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            /* str214_IV */
            String[] islands = new String[4];
            islands[0] = "Bermu";
            islands[1] = "Lepu";
            islands[2] = "Srep";
            islands[3] = "DZ";

            int[] index = new int[4];
            index[0] = 1;
            index[1] = 3;
            index[2] = 0;
            index[3] = 2;

            string result = "";
            int refNum;
            int y =0;
            while (y<4)
       	    {   
                refNum = index[y];
                result += "\nWyspa";
                result += islands[refNum];
                y++;
	        }
           MessageBox.Show(result);
            /* str214_IV */

        }


        private void str214_IV_Click(object sender, EventArgs e)
        {
            

        }
    }
}

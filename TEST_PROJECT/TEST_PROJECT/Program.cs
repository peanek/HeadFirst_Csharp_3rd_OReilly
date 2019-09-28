using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TEST_PROJECT
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
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
            
            
            /* str 263_VI_pool*/
            

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());




        }

    }
    /* str 214_IV */
    //class Triangle2
    //{
    //    /// <summary>
    //    ///     OPIS KLASUNIII
    //    ///
    //    /// </summary>
    //    double area;
    //    int height;
    //    int length;

    //    public static void Main(String[] args)
    //    {
    //        string results = "";
    //        int x = 0;
    //        Triangle2[] ta = new Triangle2[4];

    //        while (x < 4)
    //        {
    //            ta[x] = new Triangle2();
    //            ta[x].height = (x + 1) * 2;
    //            ta[x].length = x + 4;

    //            ta[x].setArea();
    //            results += "triangle " + x + " ,area ";
    //            results += "= " + ta[x].area + "\n";
    //            x++;

    //        }
    //        int y = x;
    //        x = 27;
    //        Triangle2 t5 = ta[2];
    //        ta[2].area = 343;
    //        results += "y = " + y;



    //        MessageBox.Show(results + ", t5" + t5.area);

    //    }
    //    void setArea()
    //    {
    //        area = (height * length) / 2;
    //    }
    //}
    /* str 214_IV */









}


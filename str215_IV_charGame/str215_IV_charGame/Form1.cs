﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace str215_IV_charGame
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        Stats stats = new Stats();
        public Form1()
        {
            InitializeComponent();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add((Keys)random.Next(65,90));
            if (listBox1.Items.Count>7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("GAME OVER");
                timer1.Stop();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();
                if (timer1.Interval > 400)
                    timer1.Interval -= 10;
                if (timer1.Interval > 250)
                    timer1.Interval -= 7;
                if (timer1.Interval > 100)
                    timer1.Interval -= 2;
                difficultyProgressBar.Value = 800 - timer1.Interval;
                stats.update(true);
                
            }
            else
            {
                stats.update(false);
            }

            correctLabel.Text = "correct:"+stats.Correct;
            missedLabel.Text = "missed:"+stats.Missed;
            totalLabel.Text = "total:" + stats.Total;
            accuracyLabel.Text = "accuracy:" + stats.Accuracy +" %";


        }
    }
}

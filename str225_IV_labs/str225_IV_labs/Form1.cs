using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace str225_IV_labs
{
    public partial class Form1 : Form
    {
        int minimumBet = 5;
        Guy[] guys = new Guy[3];
        Greyhound[] dogsRunning = new Greyhound[4];
        Random randomizer = new Random();


        public Form1()
        {
            InitializeComponent();
            guys[0] = new Guy() { Name = "Joe", Cash = 50, MyRadioButton = joeRadioButton, MyLabel = joeBetLabel };
            guys[1] = new Guy() { Name = "Bob", Cash = 75, MyRadioButton = bobRadioButton, MyLabel = bobBetLabel };
            guys[2] = new Guy() { Name = "Al", Cash = 45, MyRadioButton = albRadioButton, MyLabel = alBetLabel };
            
            dogsRunning[0] = new Greyhound() { Location = 0, StartingPosition = greyOne.Width, MyPictureBox = greyOne, RacetrackLength = pictureBox5.Width -greyOne.Width, MyRandom = randomizer};
            dogsRunning[1] = new Greyhound() { Location = 0, StartingPosition = greyTwo.Width, MyPictureBox = greyTwo, RacetrackLength = pictureBox5.Width - greyTwo.Width, MyRandom = randomizer };
            dogsRunning[2] = new Greyhound() { Location = 0, StartingPosition = greyThree.Width, MyPictureBox = greyThree, RacetrackLength = pictureBox5.Width - greyThree.Width, MyRandom = randomizer };
            dogsRunning[3] = new Greyhound() { Location = 0, StartingPosition = greyFourth.Width, MyPictureBox = greyFourth, RacetrackLength = pictureBox5.Width - greyFourth.Width, MyRandom = randomizer };
            
            updateLabels();


            numericBetValue.Value = minimumBet;
            numericGreyhound.Value = 1;



        }

        private void joeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            name.Text = guys[0].Name;
        }

        private void bobRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            name.Text = guys[1].Name;
        }

        private void albRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            name.Text = guys[2].Name;
        }




        public void updateLabels()
        {
            minimumBetLabel.Text = "Minimum bet : " + numericBetValue.Minimum + " $";
            guys[0].MyRadioButton.Text = "Joe amount " + guys[0].Cash + " $";
            guys[1].MyRadioButton.Text = "Bob amount " + guys[1].Cash + " $";
            guys[2].MyRadioButton.Text = "Al amount " + guys[2].Cash + " $";
            name.Text = guys[0].Name;
            bobBetLabel.Text = guys[0].Name + " gave no bet";
            joeBetLabel.Text = guys[1].Name + " gave no bet";
            alBetLabel.Text = guys[2].Name + " gave no bet";


        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void betButton_Click(object sender, EventArgs e)
        {
            int radio = 0;
            if (joeRadioButton.Checked)
            {
                radio = 0;
            }
            if (bobRadioButton.Checked)
            {
                radio = 1;
            }
            if (albRadioButton.Checked)
            {
                radio = 2;
            }

            if (guys[radio].PlaceBet((int)numericBetValue.Value, (int)numericGreyhound.Value-1))
            {
                //joeBetLabel.Text = "dupa";
                guys[radio].MyLabel.Text = name.Text + " makes a bet of " + numericBetValue.Value +
                    " $ for the grey no. " + numericGreyhound.Value;

                //new bet part of method betButtton_Click




            }
            else
            {
                MessageBox.Show(guys[0].Name + " do not have enough money for bet.");
            }
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            int winner;
            timer1.Start();
            for (int i = 0; i < dogsRunning.Length; i++)
            {
                if (dogsRunning[i].Run())
                {
                    timer1.Stop();
                    winner = i;
                    MessageBox.Show("Grey nr. "+winner+" wins !!");
                    for (int j = 0; j < guys.Length; j++)
                    {
                        if (guys[j].MyBet.Amount !=  null)
                        {
                            guys[j].Collect(winner);
                            guys[j].ClearBet();
                        }

                    }
                    for (int k = 0; k < dogsRunning.Length; k++)
                    {
                        dogsRunning[k].TakingStartingPosition();
                    }
                    updateLabels();
                    bookmakerGroup.Enabled = true;

                }
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            bookmakerGroup.Enabled = false;
            timer1.Start();
        }

        /*
        //if (joeRadioButton.Checked)
        //{
        //    if (guys[0].PlaceBet((int)numericBetValue.Value,(int)numericGreyhound.Value))
        //    {
        //        //joeBetLabel.Text = "dupa";
        //        joeBetLabel.Text = name.Text + " makes a bet of " + numericBetValue.Value +
        //            " $ for the grey no. "+ numericGreyhound.Value;
        //    }
        //    else
        //    {
        //        MessageBox.Show(guys[0].Name + " do not have enough money for bet.");
        //    }
        //}

        //if (bobRadioButton.Checked)
        //{
        //    if (guys[1].Cash < numericBetValue.Value)
        //    {
                    
        //    }
        //    else
        //    {
        //        MessageBox.Show(guys[1].Name + " do not have enough money for bet.");
        //    }
        //}

        //if (albRadioButton.Checked)
        //{
        //    if (guys[2].Cash < numericBetValue.Value)
        //    {
                    
        //    }
        //    else
        //    {
        //        MessageBox.Show(guys[1].Name + " do not have enough money for bet.");
        //    }
             
    }
    */
        //part to delete, apparently did some nice shit above
    }
}



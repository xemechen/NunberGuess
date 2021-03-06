﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameLibrary1;

namespace GuessNumberApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public double GuessedNumber = 1234;
        public int Clicks = 0;
        public int GuessTime = 0;
        public bool DoesFirstClick = false;
        public bool CanNumberGuessd = false;
        public bool CanNumberChecked = true;
        public double[] GuessedN = new double[4];
        public double AnswerNumber;
        public double[] AnswerN = new double[4];
        public bool CanInputStart = true;
        GameLibrary1.Game guessGame = new GameLibrary1.Game();


        

        public void CheckAnswer()
        {
            
            if (guessGame.CanNumberChecked == true)
                {
                    
                    
                    CurrentGuessingNumber.Text = GuessingLabel.Text;
                    InputBox.Text = "";
                    int TempGuessTime = guessGame.GuessTime;

                    if (guessGame.CheckedResult == 2)
                    {
                        TempGuessTime = guessGame.GuessTime;

                        MessageBox.Show("You tried " + guessGame.GuessTime + " time(s) and got the answer " + guessGame.GuessedN[0].ToString() + guessGame.GuessedN[1].ToString() +
                        guessGame.GuessedN[2].ToString() + guessGame.GuessedN[3].ToString());

                        guessGame.newGuessStart();
                        guessGame.Clicks = 4;
                        guessGame.GuessTime = 19;

                        MessageBox.Show("Click new guess to play again.");

                    }
                    if (guessGame.CheckedResult == 3)
                    {
                        MessageBox.Show("You guessed " + guessGame.GuessedN[0].ToString() + guessGame.GuessedN[1].ToString() +
                        guessGame.GuessedN[2].ToString() + guessGame.GuessedN[3].ToString() + " " + guessGame.countA + "A" + guessGame.countB + "B");
                        GuessingLabel.Text = "";
                        TempGuessTime = guessGame.GuessTime;
                    }
                    if (guessGame.CheckedResult == 1)
                    {
                        MessageBox.Show("Input Number cannot be repeated.");

                        Resetlabel();
                    }

                    if (TempGuessTime == 1 && guessGame.CheckedResult!=1)
                    {
                        NumberGuessed.Text = guessGame.GuessedN[0].ToString() + guessGame.GuessedN[1].ToString() +
                        guessGame.GuessedN[2].ToString() + guessGame.GuessedN[3].ToString();
                        ABcheckLabel.Text = TempGuessTime + ".   " + guessGame.countA + "A" + guessGame.countB + "B";
                    }
                    else if (guessGame.CheckedResult!=1)
                    {
                        NumberGuessed.Text = NumberGuessed.Text + "\r\n" + guessGame.GuessedN[0].ToString() + guessGame.GuessedN[1].ToString() +
                        guessGame.GuessedN[2].ToString() + guessGame.GuessedN[3].ToString();

                        if (guessGame.GuessTime >= 10)
                            ABcheckLabel.Text = ABcheckLabel.Text + "\r\n" + TempGuessTime + ".   " + guessGame.countA + "A" + guessGame.countB + "B";
                        else ABcheckLabel.Text = ABcheckLabel.Text + "\r\n" + TempGuessTime + ".   " + guessGame.countA + "A" + guessGame.countB + "B";
                    }
                    
                }
            
            
        }

        public void UpdateGuessingLabel(double GuessingNumber)
        {
            if (guessGame.Clicks <=3) 
            {

                guessGame.GuessedN[guessGame.Clicks] = GuessingNumber;


                if (guessGame.DoesFirstClick == true)
            {
                GuessingLabel.Text = GuessingNumber.ToString();
                guessGame.DoesFirstClick = false;
                guessGame.Clicks = ++guessGame.Clicks;
            }
            else
            {
            GuessingLabel.Text = GuessingLabel.Text + GuessingNumber.ToString();
            guessGame.Clicks = ++guessGame.Clicks;
            }

           

            }
            else{
            GuessingLabel.Text =GuessingLabel.Text;}
        }
        

        public void Resetlabel()
        {
            GuessingLabel.Text = "";
            InputBox.Text = "";
                        
        }

        private void InputBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.CheckNumber_Click(sender, e);
            }
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {
            if (CanInputStart == true)
            { InputBox.Text = "";
            CanInputStart = false;
            }

            //if (Clicks <= 3)
            //{
            //    Clicks = ++Clicks;
            //    if (Clicks == 4)
            //    {
            //        double.TryParse(InputBox.Text, out GuessedNumber);
            //        UpdateGuessingLabel(GuessedNumber);
            //    }
            //}
        }

        private void button7_Click(object sender, EventArgs e)// Number 1
        {
            UpdateGuessingLabel(1);
        }

        private void button8_Click(object sender, EventArgs e)// Number 2
        {
            UpdateGuessingLabel(2);
        }

        private void button9_Click(object sender, EventArgs e)// Number 3
        {
            UpdateGuessingLabel(3);
        }

        private void button4_Click(object sender, EventArgs e)// Number 4
        {
            UpdateGuessingLabel(4);
        }

        private void button5_Click(object sender, EventArgs e)// Number 5
        {
            UpdateGuessingLabel(5);
        }

        private void button6_Click(object sender, EventArgs e)// Number 6
        {
            UpdateGuessingLabel(6);
        }

        private void button1_Click(object sender, EventArgs e)// Number 7
        {
            UpdateGuessingLabel(7);
        }

        private void button2_Click(object sender, EventArgs e)// Number 8
        {
            UpdateGuessingLabel(8);
        }

        private void button3_Click(object sender, EventArgs e)// Number 9
        {
            UpdateGuessingLabel(9);
        }

        private void buttonfor0_Click(object sender, EventArgs e)
        {
            UpdateGuessingLabel(0);
        }

        public void GuessingLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void ResetGuess_Click(object sender, EventArgs e)
        {
            Resetlabel();
            guessGame.Reset();
        }

        private void CheckNumber_Click(object sender, EventArgs e)
        {
            
            
            
            char[] TempGuessedN = InputBox.Text.ToCharArray();
            if (TempGuessedN.Length == 4)
            {
                for (int index1 = 0; index1 < 4; index1++)
                {
                    guessGame.GuessedN[index1] = char.GetNumericValue(TempGuessedN[index1]);
                    
                }
                GuessingLabel.Text = guessGame.GuessedN[0].ToString() + guessGame.GuessedN[1].ToString() +
                        guessGame.GuessedN[2].ToString() + guessGame.GuessedN[3].ToString();
                guessGame.Clicks = 4;
            }
            
            if (guessGame.Clicks == 4)
            {


                if (guessGame.CanNumberGuessd == true)
                {
                    if (guessGame.GuessTime == 19)
                    {
                        String AnswerNumberText = guessGame.AnswerN[0].ToString() + guessGame.AnswerN[1].ToString() +
                           guessGame.AnswerN[2].ToString() + guessGame.AnswerN[3].ToString();
                        MessageBox.Show("Click New Guess and try again.");
                        Resetlabel();
                        guessGame.Reset();
                    }

                    else
                    {
                       guessGame.CheckAnswer();
                        CheckAnswer();
                        Scorelabel.Text = "Score: \n   " + guessGame.GameScore;
                    }
                    
                    
                    

                }
            }
        }

        private void newGuess_Click(object sender, EventArgs e)
        {
            

            guessGame.newGuessStart();
            GuessingLabel.Text = "";
            InputBox.Text = "";
            NumberGuessed.Text = "0000";
            ABcheckLabel.Text = "1.    XAXB";
            Resetlabel();

            Scorelabel.Text = "Score: \n   " + guessGame.GameScore;
            
        }

        private void Giveup_Click(object sender, EventArgs e)
        {
            InputBox.Text = "Input N here";
            String AnswerNumberText = guessGame.AnswerN[0].ToString() + guessGame.AnswerN[1].ToString() +
                   guessGame.AnswerN[2].ToString() + guessGame.AnswerN[3].ToString();
            MessageBox.Show("Answer is " + AnswerNumberText + " and you tried " + guessGame.GuessTime + " times.");
            guessGame.CanNumberGuessd = false;
            guessGame.CanNumberChecked = true;

            
        }

        private void ABcheckLabel_Click(object sender, EventArgs e)
        {
            
             
           
        }

        private void NumberGuessed_Click(object sender, EventArgs e)
        {

        }

        private void CurrentGuessingNumber_Click(object sender, EventArgs e)
        {

        }

        private void AutoRun_Click(object sender, EventArgs e)
        {
            if (comboBoxToRun.SelectedIndex == -1)
                MessageBox.Show("You need to pick one.");
            else
            {
                showNumberText = "";
                string TempText = comboBoxToRun.SelectedItem.ToString();
                int TempItem;
                int.TryParse(TempText, out TempItem);
                if (TempItem == 100 || TempItem == 500 || TempItem == 800)
                { guessGame.PCRunGame(TempItem); }

                for (int index = 0; index < 9; index++)
                {
                    int arr1 = (index + 1);
                    showNumberText = showNumberText + guessGame.StatsOfAutoRun[arr1, 0].ToString() + "      --      " + guessGame.StatsOfAutoRun[arr1, 1].ToString() +
                         " \r\n";
                }
                for (int index = 9; index < 13; index++)
                {
                    int arr1 = (index + 1);
                    showNumberText = showNumberText + guessGame.StatsOfAutoRun[arr1, 0].ToString() + "     --     " + guessGame.StatsOfAutoRun[arr1, 1].ToString() +
                         " \r\n";
                }

                showNumberText = "With " + TempItem.ToString() + " times gaming\r\n\r\n" + "Average times is " + guessGame.AverageGuessTime.ToString() + "\r\n\r\n" +
                    "Times      Counts\r\n"+showNumberText ;
                Scorelabel.Text = "Score: \n   " + guessGame.GameScore;
                MessageBox.Show(showNumberText);
            }
        }

        private void Scorelabel_Click(object sender, EventArgs e)
        {
            
        }


        

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxToRun_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public string showNumberText = "";
        public string showGuessNumberText = "";
        public string showPotenNumberText = "";
        public void showNumber(int intt, int inttt, int SeeGuess)//to check Auto run list
        {
            showNumberText = ""; showGuessNumberText = "";
            inttt = ++inttt;
            for (int index = intt; index < inttt; index++)
            {
                int arr1 = (index - 1);
                showNumberText = showNumberText + guessGame.AllNumbers[arr1, 0].ToString() + " " + guessGame.AllNumbers[arr1, 1].ToString() + guessGame.AllNumbers[arr1, 2].ToString()

                    + guessGame.AllNumbers[arr1, 3].ToString() + guessGame.AllNumbers[arr1, 4].ToString() + " " + guessGame.AllNumbers[arr1, 5].ToString() + "\r\n";
            }

            for (int index = 1; index < SeeGuess; index++)
            {
                int arr1 = (index - 1);
                showNumberText = showNumberText + guessGame.AllGuessPC[arr1, 0].ToString() + " " + guessGame.AllGuessPC[arr1, 1].ToString() + guessGame.AllGuessPC[arr1, 2].ToString()

                    + guessGame.AllGuessPC[arr1, 3].ToString() + guessGame.AllGuessPC[arr1, 4].ToString() + " " + guessGame.AllGuessPC[arr1, 5].ToString() +
                    " " + guessGame.AllGuessPC[arr1, 6].ToString() + "A" + guessGame.AllGuessPC[arr1, 7].ToString() + "B\r\n";
            }
        }

        public void showPotentialAnswer() //to check Auto run
        {
            showPotenNumberText = "";
            for (int index = 0; index < 5040; index++)
            {
                if (guessGame.AllNumbers[index, 5] == 1)
                {
                    int arr1 = index;
                    showPotenNumberText = showPotenNumberText + guessGame.AllNumbers[arr1, 0].ToString() + " " + guessGame.AllNumbers[arr1, 1].ToString() + guessGame.AllNumbers[arr1, 2].ToString()

                        + guessGame.AllNumbers[arr1, 3].ToString() + guessGame.AllNumbers[arr1, 4].ToString() + " " + guessGame.AllNumbers[arr1, 5].ToString() + "\r\n";
                }
            }
            MessageBox.Show("" + showPotenNumberText);
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            guessGame.AutoRunGame();
            String AnswerNumberText = guessGame.AnswerN[0].ToString() + guessGame.AnswerN[1].ToString() +
                       guessGame.AnswerN[2].ToString() + guessGame.AnswerN[3].ToString();
            MessageBox.Show("Answer is " + AnswerNumberText + ".");


            MessageBox.Show("" +
            guessGame.GuessedN[0].ToString() + guessGame.GuessedN[1].ToString() +
                        guessGame.GuessedN[2].ToString() + guessGame.GuessedN[3].ToString()
                        + " " + guessGame.countA + "A" + guessGame.countB + "B" + guessGame.GuessTime.ToString());

            showNumber(1, 1, 15);
            MessageBox.Show(showNumberText);

            showPotentialAnswer();
            

            MessageBox.Show(guessGame.rdNumber + " " + guessGame.GuessTime.ToString()+" " + guessGame.AverageGuessTime.ToString());
           

             

        //    guessGame.newGuessStart();

        //    double[] arr2 = new double[4];
        //    int b = 1;
        //    for (int inde = 0; inde < 4; inde++)
        //    {
        //        arr2[inde] = b;
        //        b = ++b;
        //    }
        //    GuessedN = arr2;

        //    String GuessNumberText = GuessedN[0].ToString() + GuessedN[1].ToString() +
        //           GuessedN[2].ToString() + GuessedN[3].ToString();
        //    MessageBox.Show("Your guess is " + GuessNumberText + ".");
        //    CheckAnswer();
        //    String AnswerNumberText = AnswerN[0].ToString() + AnswerN[1].ToString() +
        //           AnswerN[2].ToString() + AnswerN[3].ToString();
        //    MessageBox.Show("Answer is " + AnswerNumberText + ".");
        }

        private void GetAnswer_Click(object sender, EventArgs e)
        {
            String AnswerNumberText = guessGame.AnswerN[0].ToString() + guessGame.AnswerN[1].ToString() +
                       guessGame.AnswerN[2].ToString() + guessGame.AnswerN[3].ToString();
            MessageBox.Show("Answer is " + AnswerNumberText + ".");
        }

        
    }
}

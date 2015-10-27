using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        Game guessGame = new Game();


        public void newGuessStart()
        {
            guessGame.CreateAnswer();
            AnswerN = guessGame.Answer;
            GuessingLabel.Text = "";
            InputBox.Text = "";
            NumberGuessed.Text = "0000";
            ABcheckLabel.Text = "1.    XAXB";
            CanNumberGuessd = true;
            Reset();
            GuessTime = 0;
        }

        public void CheckAnswer()
        {
            
                for (int index = 0; index < 3; index++)
                {

                    for (int idx = index + 1; idx < 4; idx++)
                    {
                        if (GuessedN[index] == GuessedN[idx])
                        {
                            CanNumberChecked = false;
                        }
                    }
                }

                if (CanNumberChecked == true)
                {
                    int countA = 0; int countB = 0;
                    double[] guessarr = new double[4];
                    for (int index = 0; index < 4; index++)
                    {
                        for (int idx = 0; idx < 4; idx++)
                        {
                            if (GuessedN[index] == AnswerN[idx])
                            {
                                countB = ++countB;

                                if (index == idx)
                                {
                                    countB = --countB;
                                    countA = ++countA;
                                }
                            }
                        }
                    }

                    double.TryParse(GuessingLabel.Text, out GuessedNumber);
                    String GuessedNumberTExt = GuessedN[0].ToString() + GuessedN[1].ToString() +
                        GuessedN[2].ToString() + GuessedN[3].ToString();


                    if (countA == 4)
                    {
                        GuessTime = ++GuessTime;
                        MessageBox.Show("You tried " + GuessTime + " times and got the answer " + GuessedN[0].ToString() + GuessedN[1].ToString() +
                        GuessedN[2].ToString() + GuessedN[3].ToString());
                        newGuessStart();
                        MessageBox.Show("A new guess just began.");
                    }
                    else
                    {
                        MessageBox.Show("You guessed " + GuessedNumberTExt + " " + countA + "A" + countB + "B");
                        GuessingLabel.Text = "";
                        Clicks = 0;
                        GuessTime = ++GuessTime;
                    }

                    if (GuessTime == 1)
                    {
                        NumberGuessed.Text = GuessedNumber.ToString();
                        ABcheckLabel.Text = GuessTime + ".   " + countA + "A" + countB + "B";
                    }
                    else
                    {
                        NumberGuessed.Text = NumberGuessed.Text + "\r\n" + GuessedNumber.ToString();
                        ABcheckLabel.Text = ABcheckLabel.Text + "\r\n" + GuessTime + ".   " + countA + "A" + countB + "B";
                    }
                    CurrentGuessingNumber.Text = NumberGuessed.Text;
                }
                else
                {
                    MessageBox.Show("Input Number cannot be repeated.");
                    Reset();
                }
            
        }

        public void UpdateGuessingLabel(double GuessingNumber)
        {
            if (Clicks <=3) 
            {

                GuessedN[Clicks] = GuessingNumber;
                

            if (DoesFirstClick == true)
            {
                GuessingLabel.Text = GuessingNumber.ToString();
                DoesFirstClick = false;
                Clicks = ++Clicks;
            }
            else
            {
            GuessingLabel.Text = GuessingLabel.Text + GuessingNumber.ToString();
            Clicks = ++Clicks;
            }

           

            }
            else{
            GuessingLabel.Text =GuessingLabel.Text;}
        }
        

        public void Reset()
        {
            GuessingLabel.Text = "";
            InputBox.Text = "";
            Clicks = 0;
            CanNumberChecked = true;
            
        }


        private void InputBox_TextChanged(object sender, EventArgs e)
        {
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

        private void GuessingLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void ResetGuess_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void CheckNumber_Click(object sender, EventArgs e)
        {
            if (Clicks == 4)
            {
                

                if (CanNumberGuessd == true)
                {
                    if (GuessTime == 19)
                    { 
                        String AnswerNumberText = AnswerN[0].ToString() + AnswerN[1].ToString() +
                           AnswerN[2].ToString() + AnswerN[3].ToString();
                        MessageBox.Show("Answer is " + AnswerNumberText + " and you tried " + "20" + " times.");
                        Reset(); 
                    }

                    else
                    {
                       CheckAnswer(); 
                    }
                    
                    
                    

                }
            }
        }

        private void newGuess_Click(object sender, EventArgs e)
        {


            newGuessStart();
            CanNumberChecked = true;

                String AnswerNumberText = AnswerN[0].ToString() + AnswerN[1].ToString() +
                       AnswerN[2].ToString() + AnswerN[3].ToString();
                MessageBox.Show("Answer is " + AnswerNumberText + " with " + GuessTime + " times guessing.");
        }

        private void Giveup_Click(object sender, EventArgs e)
        {
            InputBox.Text = "Input N here";
            String AnswerNumberText = AnswerN[0].ToString() + AnswerN[1].ToString() +
                   AnswerN[2].ToString() + AnswerN[3].ToString();
            MessageBox.Show("Answer is " + AnswerNumberText + " and you tried "+ GuessTime+" times.");
            CanNumberGuessd = false;
            CanNumberChecked = true;
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
            newGuessStart();

            double[] arr2 = new double[4];
            int b = 1;
            for (int inde = 0; inde < 4; inde++)
            {
                arr2[inde] = b;
                b = ++b;
            }
            GuessedN = arr2;

            String GuessNumberText = GuessedN[0].ToString() + GuessedN[1].ToString() +
                   GuessedN[2].ToString() + GuessedN[3].ToString();
            MessageBox.Show("Your guess is " + GuessNumberText + ".");
            CheckAnswer();
            String AnswerNumberText = AnswerN[0].ToString() + AnswerN[1].ToString() +
                   AnswerN[2].ToString() + AnswerN[3].ToString();
            MessageBox.Show("Answer is " + AnswerNumberText + ".");
        }
    }
}

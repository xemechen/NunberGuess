﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberApplication
{
    public class Game
    {
        public double[] Answer = new double[4];
        public double[] Guess = new double[4];
        public bool DoesFirstClick = false;
        public bool CanNumberGuessd = false;
        public bool CanNumberChecked = true;
        public int Clicks=0;
        public double[] GuessedN = new double[4];
        public double[] AnswerN = new double[4];
        public int GuessTime = 0;
        public double GuessedNumber = 1234;
        public double AnswerNumber;


        public void newGuessStart()
        {
            CreateAnswer();
            AnswerN = Answer;
            CanNumberGuessd = true;
            GuessTime = 0;
        }
        

        public void CreateGuessNumber()
        {
            Random random = new Random();
            double[] arr2 = new double[4];
            for (int inde = 0; inde < 4; inde++)
            {
                int b = random.Next(1, 10);
                for (int idex = 0; idex < inde; idex++)
                    while (arr2[idex] == b)
                    {
                        b = random.Next(1, 10);
                    }

                arr2[inde] = b;


            }
            Guess = arr2;
            return;
        }

        public void CreateAnswer()
        {
            Random random = new Random();
            double[] arr = new double[4];
            for (int index = 0; index < 4; index++)
            {
                int a = random.Next(1, 10);
                for (int idx = 0; idx < index; idx++)
                    while (arr[idx] == a)
                    {
                        a = random.Next(1, 10);
                    }

                arr[index] = a;


            }
            Answer = arr;
            return;
            //public int[] AnswerN = new int[4] { arr[0], 3, 5, 7 };
            //return;
        }

        //public List<int> Answer = new List<int>(); // public int[] Answer = new int[4]; // or 

        //public string GetResult(List<int> userAnswer)
        //{
        //    int CountA = 0;
        //    int CountB = 0;
        //    for (int userAnswerIndex = 0; userAnswerIndex < 4; userAnswerIndex++)
        //    {
        //        for (int answerIndex = 0; answerIndex < 4; answerIndex++)
        //        {
        //            if (userAnswer[userAnswerIndex] == this.Answer[answerIndex])
        //            {
        //                if (userAnswerIndex == answerIndex)
        //                    CountA++;
        //                else
        //                    CountB++;
        //            }

        //        }
        //    }
        //    return string.Format("{0}A {1}B", CountA, CountB);
        //}

        //private void CreateAnswer()
        //{
        //    Random random = new Random();
        //    do{
        //    int number = random.Next(1,10);
        //        if (!this.ISNumberRepeated(number))

        //    }
        //}

        //private bool ISNumberRepeated(int number)
        //{
        //    for (int index = 0; index < Answer.Count; index++)
        //    {
        //        if (number == Answer[index])
        //            return true;
        //    }
        //}

    }
}
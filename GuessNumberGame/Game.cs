using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame
{
    public class Game
    {
        public int[] AnswerN=new int[4];
        public void CreateAnswerN()
        {
            Random random = new Random();
            int[] arr = new int[4];
            for (int index = 0; index < 4; index++)
            {
                int a = random.Next(1, 10);
                for (int idx = 0; idx < index; idx++)
                    while (arr[idx] == a)
                    {
                        a = random.Next(1, 10);
                    }

                arr[index]=a;
                
                
            }
            AnswerN=arr;
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

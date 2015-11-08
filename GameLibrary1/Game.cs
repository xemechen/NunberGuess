using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary1
{
    public class Game
    {
        Random random = new Random(Guid.NewGuid().GetHashCode());
        Random simplerandom = new Random();
        public double[] Answer = new double[4];
        public double[] Guess = new double[4];
        public bool DoesFirstClick = false;
        public bool CanNumberGuessd = false;
        public bool CanNumberChecked = true;
        public int Clicks = 0;
        public double[] GuessedN = new double[4];
        public double[] AnswerN = new double[4];
        public int GuessTime = 0;
        public double GuessedNumber = 1235;
        public double AnswerNumber;
        public int countA = 2; public int countB = 0;
        public int CheckedResult = 0;
        public int GameScore = 0;
        public double[,] AllNumbers = new double[6000, 6];// [No.], [1st N], [2nd N], [3rd N], [4th N], [if Potential Ans]
        public double[,] AllGuessPC = new double[100, 8]; 
        // [No.], [1st N], [2nd N], [3rd N], [4th N], [if Potential Ans], [A counts], [B counts]
        public double SumOfAllGuessTime;
        public double AverageGuessTime;
        public double[,] StatsOfAutoRun = new double[15,2]; 




        public void PCRunGame(int times)
        {

            for (int indx = 0; indx < 15; indx++)
            { StatsOfAutoRun[indx, 0] = indx;
            StatsOfAutoRun[indx, 1] = 0;
            }

            SumOfAllGuessTime = 0;
            for (int index = 0; index < times; index++)
            {
                AutoRunGame();
                RenewPCGuess();
                GuessTime = 0;
            }
            AverageGuessTime = SumOfAllGuessTime / times;
        
        }

        public void AutoRunGame()
        {
            CreateAll();
            
            //AnswerN[0]= 9; AnswerN[1]=8 ; AnswerN[2]=7 ; AnswerN[3]=5 ;
            newGuessStart();
            CreateGuess2();

            CheckAnswer();
            AllGuessPC[0 , 6] = countA; AllGuessPC[0 , 7] = countB;

            if (CheckedResult != 2)
            {
                CheckPCAnswer();

                CreateGuess2and2();
                CheckAnswer();
                AllGuessPC[1, 6] = countA; AllGuessPC[1, 7] = countB;
            }
            if (CheckedResult != 2)
            {
                CheckPCAnswer();
                CreateGuess2and3();

                CheckAnswer();
                AllGuessPC[2, 6] = countA; AllGuessPC[2, 7] = countB;

            }
            if (CheckedResult != 2)
            {
                CheckPCAnswer();
                CreateGuess2and3();

                CheckAnswer();
                AllGuessPC[3, 6] = countA; AllGuessPC[3, 7] = countB;

            }

            if (CheckedResult != 2)
            {
                CheckPCAnswer();
                CreateGuess2and3();

                CheckAnswer();
                AllGuessPC[4, 6] = countA; AllGuessPC[4, 7] = countB;

            }
            if (CheckedResult != 2)
            {
                CheckPCAnswer();
                CreateGuess2and3();

                CheckAnswer();
                AllGuessPC[5, 6] = countA; AllGuessPC[5, 7] = countB;

            }
            if (CheckedResult != 2)
            {
                CheckPCAnswer();
                CreateGuess2and3();

                CheckAnswer();
                AllGuessPC[6, 6] = countA; AllGuessPC[6, 7] = countB;

            }
            if (CheckedResult != 2)
            {
                CheckPCAnswer();
                CreateGuess2and3();

                CheckAnswer();
                AllGuessPC[7, 6] = countA; AllGuessPC[7, 7] = countB;

            }
            if (CheckedResult != 2)
            {
                CheckPCAnswer();
                CreateGuess2and3();

                CheckAnswer();
                AllGuessPC[8, 6] = countA; AllGuessPC[8, 7] = countB;

            }
            if (CheckedResult != 2)
            {
                CheckPCAnswer();
                CreateGuess2and3();

                CheckAnswer();
                AllGuessPC[9, 6] = countA; AllGuessPC[9, 7] = countB;

            }
            if (CheckedResult != 2)
            {
                CheckPCAnswer();
                CreateGuess2and3();

                CheckAnswer();
                AllGuessPC[10, 6] = countA; AllGuessPC[10, 7] = countB;

            }
            if (CheckedResult != 2)
            {
                CheckPCAnswer();
                CreateGuess2and3();

                CheckAnswer();
                AllGuessPC[11, 6] = countA; AllGuessPC[11, 7] = countB;

            }
            if (CheckedResult != 2)
            {
                CheckPCAnswer();
                CreateGuess2and3();

                CheckAnswer();
                AllGuessPC[12, 6] = countA; AllGuessPC[12, 7] = countB;

            }
            if (CheckedResult != 2)
            {
                CheckPCAnswer();
                CreateGuess2and3();

                CheckAnswer();
                AllGuessPC[13, 6] = countA; AllGuessPC[13, 7] = countB;

            }
            if (CheckedResult != 2)
            {
                CreateAll();
                newGuessStart();

            }

            if (CheckedResult == 2)
            {
                SumOfAllGuessTime = SumOfAllGuessTime + GuessTime;
                StatsOfAutoRun[GuessTime, 1] = StatsOfAutoRun[GuessTime, 1]+1;
                countA = 0;
            }

            //int TempCount = 5;
            //while (countA!=4)
            //{
            //    CheckPCAnswer();
            //    CreateGuess2and3();

            //    CheckAnswer();
            //    AllGuessPC[TempCount, 6] = countA; AllGuessPC[TempCount, 7] = countB;

            //    if (TempCount >= 7)
            //        break;
            //}


            //else if (countA==4)
            //    AllGuessPC[GuessTime, 6] = countA; AllGuessPC[GuessTime, 7] = countB;


            //if (countA != 4)
            //{
            //    CheckPCAnswer();
            //    CreateSimilarGuessNumber();
            //    CheckAnswer();
            //    AllGuessPC[2, 6] = countA; AllGuessPC[2, 7] = countB;

            //    double firstEightN = (AllGuessPC[0, 6] + AllGuessPC[0, 7] + AllGuessPC[1, 6] + AllGuessPC[1, 7]);
            //    if (firstEightN == 4)
            //    { }
            //    else if (firstEightN == 3)
            //    { }
            //    else//firstEightN==2
            //    { }
                

            //}
            


            
            
        }
        

        public string rdNumber;
        public void CreateGuess2and3()
        {
            double potentialAnswerLength=0;
            for (int index=0;index<5040;index++)
            { 
                potentialAnswerLength= (AllNumbers[index,5]==1)?++potentialAnswerLength:potentialAnswerLength;
                            
            }
            
                int FindOneSetByRdm = (int)(random.Next(1, 5040) % potentialAnswerLength);
                if (FindOneSetByRdm == 0) FindOneSetByRdm = FindOneSetByRdm + 1;
                rdNumber = FindOneSetByRdm.ToString();
                rdNumber = rdNumber + " " + potentialAnswerLength.ToString();

                int x = 0;
                for (int index = 0; index < 5040; index++)
                {
                    if (AllNumbers[index, 5] == 1)
                    {
                        x++;
                        if (FindOneSetByRdm == x)
                        {
                            for (int y = 0; y < 4; y++)
                                AllGuessPC[GuessTime, y + 1] = GuessedN[y] = AllNumbers[index, y + 1];
                        }
                    }
                }
                AllGuessPC[GuessTime, 0] = GuessTime + 1;
            
            //double[] arr2 = new double[4];
            
            
            //    for (int inde = 0; inde < 4; inde++)
            //    {
            //        int b = (simplerandom.Next(0, 10));
                    

            //        for (int idex = 0; idex < inde; idex++)
            //        {
            //            while (arr2[idex] == b || AllGuessPC[0, idex + 1] == b)
            //            {
            //                b = (simplerandom.Next(0, 10));
            //            }
            //        }
                   
            //        arr2[inde] = b;                    
            //        AllGuessPC[GuessTime, inde + 1] = b;
            //        AllGuessPC[GuessTime, 0] = GuessTime + 1;

            //    }
            //    Guess = arr2; GuessedN = Guess;




            

        }
        
        
        public void CreateAll()
        {
            int index = 0;
            bool indexAdd;
            
            for (int a1 = 0; a1 < 10; a1++)
            {
                

                for (int a2 = 0; a2 < 10; a2++)
                {   
                    for (int a3 = 0; a3 < 10; a3++)
                    {
                        for (int a4 = 0; a4 < 10; a4++)
                        {                            
                            AllNumbers[index, 0] = 1 + index;
                            AllNumbers[index, 1] = a1; AllNumbers[index, 2] = a2;
                            AllNumbers[index, 3] = a3; AllNumbers[index, 4] = a4;
                            AllNumbers[index, 5] = 1; 
                            indexAdd = true;

                            for (int ind = 1; ind < 4; ind++)
                            {

                                for (int idx = ind + 1; idx < 5; idx++)
                                {
                                    if (AllNumbers[index, ind] == AllNumbers[index, idx])
                                    {

                                        indexAdd = false;
                                    }
                                }
                            }
                            if (indexAdd == true)
                                index = ++index;
                        }

                    }
                }
            }
            AllNumbers[index, 0] = 0;
            AllNumbers[index, 1] = 0; AllNumbers[index, 2] = 0;
            AllNumbers[index, 3] = 0; AllNumbers[index, 4] = 0;



            



        }
        public void RenewPCGuess()
        {
            for (int index = 0; index < 100; index++)
            {
                AllGuessPC[index, 0] = 0;
                AllGuessPC[index, 1] = 0; AllGuessPC[index, 2] = 0;
                AllGuessPC[index, 3] = 0; AllGuessPC[index, 4] = 0;
                AllGuessPC[index, 5] = 0; AllGuessPC[index, 6] = 0; AllGuessPC[index, 7] = 0;

            }

        }

        public void Reset()
        {

            Clicks = 0;
            CanNumberChecked = true;
            CheckedResult = 0;

        }

        public void newGuessStart()
        {
            CreateAnswer2();
            AnswerN = Answer;
            CanNumberGuessd = true;
            CanNumberChecked = true;
            GuessTime = 0;
            Reset();

        }

        public void CheckAnswer()
        {
            countA = 0; countB = 0;
            for (int index = 0; index < 3; index++)
            {

                for (int idx = index + 1; idx < 4; idx++)
                {
                    if (GuessedN[index] == GuessedN[idx])
                    {
                        CanNumberChecked = false;
                        CheckedResult = 1;
                    }
                }
            }

            if (CanNumberChecked == true)
            {

                
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



                if (countA == 4)
                {
                    GuessTime = ++GuessTime;
                    CheckedResult = 2;

                    if (GuessTime <= 6)
                        GameScore = GameScore + (21 - GuessTime) * 3;
                    else if (GuessTime <= 11)
                        GameScore = GameScore + (21 - GuessTime) * 2;
                    else
                        GameScore = GameScore + 21 - GuessTime;


                }
                else
                {

                    Clicks = 0;
                    GuessTime = ++GuessTime;
                    CheckedResult = 3;
                }


            }
            else
            {

                Clicks = 0;
                CanNumberChecked = true;
                
            }

        }

        public void CheckPCAnswer()
        {
            
            int TempCountA = 0; int TempCountB = 0;



            for (int arr = 0; arr < 5040; arr++)
            {
                TempCountA = 0; TempCountB = 0;

                for (int index = 0; index < 4; index++)
                {
                    for (int idx = 1; idx < 5; idx++)
                    {
                        if (GuessedN[index] == AllNumbers[arr, idx])
                        {
                            TempCountB = ++TempCountB;

                            if (index == (idx - 1))
                            {
                                TempCountB = --TempCountB;
                                TempCountA = ++TempCountA;
                            }
                        }
                    }
                }
                if (TempCountA == countA && TempCountB == countB)
                    AllNumbers[arr, 5] = AllNumbers[arr, 5];
                else
                    AllNumbers[arr, 5] = 0;
            }


               


            
           

        }

       

        

        
        public void CreateAnswer2()
        {

            for (int index = 0; index < 4; index++)
            { Answer[index] = random.Next(0, 10); }


            bool checkIfRepeat=false;
            for (int index2 = 0; index2 < 3; index2++)
            {
                for (int index3 = (index2 + 1); index3 < 4; index3++)
                {
                    if (Answer[index2] == Answer[index3])
                        checkIfRepeat = true;
                }
            }

            while (checkIfRepeat == true)
            {
                for (int index = 0; index < 4; index++)
                { Answer[index] = random.Next(0, 10); }


                checkIfRepeat = false;
                for (int index2 = 0; index2 < 3; index2++)
                {
                    for (int index3 = (index2 + 1); index3 < 4; index3++)
                    {
                        if (Answer[index2] == Answer[index3])
                            checkIfRepeat = true;
                    }
                }
            }

        
        }
        public void CreateGuess2()
        {

            for (int index = 0; index < 4; index++)
            { 
                AllGuessPC[GuessTime , index + 1] = random.Next(0, 10);
                GuessedN[index] = AllGuessPC[GuessTime, index + 1];
            }


            bool checkIfRepeat = false;
            for (int index2 = 0; index2 < 3; index2++)
            {
                for (int index3 = (index2 + 1); index3 < 4; index3++)
                {
                    if (AllGuessPC[GuessTime, index2 + 1] == AllGuessPC[GuessTime, index3 + 1])
                        checkIfRepeat = true;
                }
            }

            while (checkIfRepeat == true)
            {
                for (int index = 0; index < 4; index++)
                {
                    AllGuessPC[GuessTime, index + 1] = random.Next(0, 10);
                    GuessedN[index] = AllGuessPC[GuessTime, index + 1];
                }


                checkIfRepeat = false;
                for (int index2 = 0; index2 < 3; index2++)
                {
                    for (int index3 = (index2 + 1); index3 < 4; index3++)
                    {
                        if (AllGuessPC[GuessTime, index2 + 1] == AllGuessPC[GuessTime, index3 + 1])
                            checkIfRepeat = true;
                    }
                }


            }
            AllGuessPC[GuessTime, 0] = GuessTime + 1;

        }
        public void CreateGuess2and2()
        {
            double[,] AllTen = new double[10, 2];
            for (int count1 = 0; count1 < 10; count1++)
            { AllTen[count1, 0] = count1; AllTen[count1, 1] = 0; }

            for (int index = 0; index < 4; index++)
            {
                int x=(int)AllGuessPC[GuessTime-1, index + 1];
                AllTen[x, 1]=1;
            }

            int z=0;
            while (z<=3)
            {
                int y = random.Next(0, 10);
                if (AllTen[y, 1] == 0)
                {
                    AllGuessPC[GuessTime, (z + 1)] = AllTen[y, 0]; AllTen[y, 1] = 1;
                    GuessedN[z] = AllTen[y, 0];
                    z++;
                }

            }
            AllGuessPC[GuessTime, 0] = GuessTime + 1;

            //    for (int index = 0; index < 4; index++)
            //    {
            //        AllGuessPC[GuessTime, index + 1] = random.Next(0, 10);
            //        GuessedN[index] = AllGuessPC[GuessTime, index + 1];
            //    }


            //bool checkIfRepeat = false;
            //for (int index2 = 0; index2 < 3; index2++)
            //{
            //    for (int index3 = (index2 + 1); index3 < 4; index3++)
            //    {
            //        if (AllGuessPC[GuessTime, index2 + 1] == AllGuessPC[GuessTime, index3 + 1])
            //            checkIfRepeat = true;
            //    }
            //}

            //while (checkIfRepeat == true)
            //{
            //    for (int index = 0; index < 4; index++)
            //    {
            //        AllGuessPC[GuessTime, index + 1] = random.Next(0, 10);
            //        GuessedN[index] = AllGuessPC[GuessTime, index + 1];
            //    }


            //    checkIfRepeat = false;
            //    for (int index2 = 0; index2 < 3; index2++)
            //    {
            //        for (int index3 = (index2 + 1); index3 < 4; index3++)
            //        {
            //            if (AllGuessPC[GuessTime, index2 + 1] == AllGuessPC[GuessTime, index3 + 1])
            //                checkIfRepeat = true;
            //        }
            //    }

            //    if (checkIfRepeat == false)
            //    {
            //        for (int index4 = 0; index4 < 4; index4++)
            //        {
            //            for (int index5 = 0; index5 < 4; index5++)
            //            {
            //                if (AllGuessPC[GuessTime, index4 + 1] == AllGuessPC[GuessTime - 1, index5 + 1])
            //                    checkIfRepeat = true;
            //            }
            //        }
            //    }

            //}
            //AllGuessPC[GuessTime, 0] = GuessTime + 1;


            


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
        public void CreateAnswer()
        {
            double[] arr = new double[4] { 10, 10, 10, 10 };
            for (int index = 0; index < 4; index++)
            {
                int a = random.Next(0, 10);
                for (int idx = 0; idx < index; idx++)
                {
                    while (arr[idx] == a)
                    {
                        a = random.Next(0, 10);
                    }
                }
                arr[index] = a;


            }


            Answer = arr;
            return;
            //public int[] AnswerN = new int[4] { arr[0], 3, 5, 7 };
            //return;
        }
        public void CreateGuessNumber()
        {

            double[] arr2 = new double[4] { 10, 10, 10, 10 };
            for (int index = 0; index < 4; index++)
            {
                int b = (random.Next(0, 10));
                for (int idex = 0; idex < index; idex++)
                {
                    while (arr2[idex] == b)
                    {
                        b = (random.Next(0, 10));
                    }
                }

                arr2[index] = b;
                AllGuessPC[GuessTime, index + 1] = b;
                AllGuessPC[GuessTime, 0] = GuessTime + 1;

            }
            Guess = arr2; GuessedN = Guess;
            return;
        }
        public void CreateSimilarGuessNumber()
        {
            //if ((AllGuessPC[0, 6] + AllGuessPC[0, 7]) == 2)
            {
                int TempCountB = 0;
                double firstEightN = (AllGuessPC[0, 6] + AllGuessPC[0, 7] + AllGuessPC[1, 6] + AllGuessPC[1, 7]);
                //while (TempCountB != firstEightN)
                {
                    double[] arr2 = new double[6];
                    TempCountB = 0;

                    for (int inde = 0; inde < 4; inde++)
                    {
                        int b = (random.Next(0, 10));
                        for (int idex = 0; idex < inde; idex++)
                            while (arr2[idex] == b)
                            {
                                b = (random.Next(0, 10));
                            }

                        arr2[inde] = b;
                        AllGuessPC[GuessTime, inde + 1] = b;
                        AllGuessPC[GuessTime, 0] = GuessTime + 1;

                    }

                    for (int index = 1; index < 5; index++)
                    {
                        for (int idx = index; idx < 5; idx++)

                            if (AllGuessPC[0, index] == AllGuessPC[GuessTime, idx])
                            {
                                TempCountB = ++TempCountB;


                            }

                    }
                    for (int index = 1; index < 5; index++)
                    {
                        for (int idx = index; idx < 5; idx++)

                            if (AllGuessPC[1, index] == AllGuessPC[GuessTime, idx])
                            {
                                TempCountB = ++TempCountB;


                            }

                    }
                    GuessedN = arr2;
                }
            }

        }
        
    }
}
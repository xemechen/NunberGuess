using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
           Game guessGame= new Game();

           guessGame.CreateAnswerN();
           for (; ; )
           {
               
               string Escape = Console.ReadLine();
               if (Escape == "y"||Escape == "Y")
                   Console.WriteLine("{0}{1}{2}{3}",
                   guessGame.AnswerN[0], guessGame.AnswerN[1], guessGame.AnswerN[2], guessGame.AnswerN[3]);
               else
                   break;


           }

           ;
        }
    }
}

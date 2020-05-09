using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Final_Game
{
    class Trivia
    {
        public string Question;
        public string Answer;

        public Trivia(string question, string answer)
        {
            Question = question;
            Answer = answer;
        }

        public void AskQuestion()
        {
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("Question : " + Question);
            WriteLine("Your Answer is : ");
            string playerAnswer = ReadLine();
            WriteLine("You answered \"" + playerAnswer + "\".");
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine("The correct answer is : " + Answer);
        }

    }
}

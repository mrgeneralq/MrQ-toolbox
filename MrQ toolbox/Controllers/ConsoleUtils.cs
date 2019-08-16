using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrQ_toolbox.Controllers
{
    public class ConsoleUtils
    {

        public static string AskQuestion(string question)
        {
            Console.WriteLine(question);
            string answer = Console.ReadLine();
            return answer;
        }

        public static string AskQuestion(string question, ConsoleColor textColor, bool resetColor)
        {
            Console.ForegroundColor = textColor;
            var answer = AskQuestion(question);

            if(resetColor)
            Console.ResetColor();

            return answer;
        }


        public static void Write(string message)
        {
            Console.Write(message);
        }

        public static void Write(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(message);
            Console.ResetColor();
        }

        public static void WriteLine(string message)
        {
            Console.WriteLine(message);
        }

        public static void WriteLine(string message, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(message);
            Console.ResetColor();
        }

        public static bool AskYesNo(string question, bool newLine)
        {
            string questionFormat = string.Format("{0} y/n : ", question);

            if (newLine)
                WriteLine(questionFormat);
            else
                Write(questionFormat);

                var answer = Console.ReadLine();

            if (answer.ToLower() != "y" && answer.ToLower() != "n" && answer.ToLower() != "yes" && answer.ToLower() != "no")
            {
                WriteLine("Invalid format!", ConsoleColor.DarkRed);
                return AskYesNo(question, newLine);
            }

            if (answer.ToLower().StartsWith("y"))
                return true;
            return false;
        }

    }
}

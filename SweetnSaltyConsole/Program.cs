using System;

namespace SweetnSaltyConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 1;
            int sweetCount = 0, saltyCount = 0, sAndsCount = 0;
            //the string which is written to the console for each number
            string outputString = "";
            while (counter <= 1000)
            {
                if (counter % 3 == 0 && counter % 5 == 0) { outputString = "sweet'nSalty "; sAndsCount++; }
                //handles numbers only divisible by 3, not by 5
                else if (counter % 3 == 0) { outputString = "sweet "; sweetCount++; }
                else if (counter % 5 == 0) { outputString = "salty "; saltyCount++; }
                else outputString = counter.ToString() + " ";

                //every tenth number is divisible by 10, at which point a new line must be started
                if (counter % 10 == 0) Console.WriteLine(outputString);
                else Console.Write(outputString);

                counter++;
            }
            Console.Write($"{sweetCount}\n{saltyCount}\n{sAndsCount}");
        }
    }
}

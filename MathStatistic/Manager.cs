using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MathStatistic
{
    class Manager
    {

        public Manager()
        {
            var getNumbers = new GetNumbers();
            Clear();
            while (true)
            {
                Console.WriteLine("Choose action:");
                var key = Console.ReadKey().Key;
                if (key == ConsoleKey.Q)
                {
                    Environment.Exit(0);
                }
                Console.WriteLine();
                switch (key)
                {
                    case ConsoleKey.NumPad1:
                        Console.WriteLine($"{MathOperations.ArithmeticMean(getNumbers.GetUserNumbers())}");
                        break;
                    case ConsoleKey.NumPad2:
                        Console.WriteLine($"{MathOperations.MathematicalExpectation(getNumbers.GetUserNumbers())}");
                        break;
                    case ConsoleKey.NumPad3:
                        Console.WriteLine($"{MathOperations.Variance(getNumbers.GetUserNumbers())}");
                        break;
                    case ConsoleKey.C:
                        Clear();
                        break;
                    default:
                        break;
                }
            }
        }

        public void Clear()
        {
            Console.Clear();
            Console.Write("Menu:" +
                          "\n1 - Arithmetic Mean;" +
                          "\n2 - Mathematical Expectation;" +
                          "\n3 - Variance" +
                          "\nc - Clear;" +
                          "\nq - Exit." +
                          "\n");
        }
    }
}

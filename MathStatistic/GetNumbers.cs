using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathStatistic
{
    class GetNumbers
    {
        public List<double> GetUserNumbers()
        {
            List<double> numbers = new List<double>();
            Console.Write("Input numbers:" +
                          "\ne - end" +
                          "\n");
            const string End = "e";
            while (true)
            {
                string line = Console.ReadLine();
                if (line.Trim().Equals(End))
                    break;
                if (int.TryParse(line, out int number))
                    numbers.Add(number);
            }
            return numbers;
        }
    }
}

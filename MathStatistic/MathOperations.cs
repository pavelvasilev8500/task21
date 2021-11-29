using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathStatistic
{
    static class MathOperations
    {
        public static double ArithmeticMean(List<double> numbers)
        {
            double sum = 0;
            foreach (var n in numbers)
                sum += n;
            return sum/numbers.Count;
        }

        public static double MathematicalExpectation(List<double> numbers)
        {
            double sum = 0;
            foreach (var n in numbers)
                sum += (n/numbers.Count);
            return sum;
        }

        public static double Variance(List<double> numbers)
        {
            double sum = 0;
            foreach (var n in numbers)
                sum += Math.Pow((n-ArithmeticMean(numbers)), 2);
            return sum / numbers.Count; 
        }
    }


}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringCalc
    {
        public int Add(string numbers)
        {
            if (string.IsNullOrEmpty(numbers))
            {
                return 0;
            }

            string[] splitNumbers = numbers.Split(new char[] { ',', '\n' });
            int sum = 0;
            List<int> negativeNumbers = new List<int>();
            foreach (string splitNumber in splitNumbers)
            {
                int num = int.Parse(splitNumber);
                if (num < 0)
                {
                    negativeNumbers.Add(num);
                }
                sum += num;
            }

            if (negativeNumbers.Count > 0)
            {
                string message = "negatives not allowed: ";
                for (int i = 0; i < negativeNumbers.Count; i++)
                {
                    if (i > 0)
                    {
                        message += ", ";
                    }
                    message += negativeNumbers[i];
                }
                throw new ArgumentException(message);
            }

            return sum;
        }
    }
}

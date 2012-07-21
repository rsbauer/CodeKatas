using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TDDProgram
{
    public class FizzBuzz
    {
        public const string FIZZ = "Fizz";
        public const string BUZZ = "Buzz";


        public string Calculate(int number)
        {
            string result = "";

            if (number % 3 == 0)
                result += FIZZ;

            if (number % 5 == 0)
                result += BUZZ;

            if (string.IsNullOrEmpty(result))
                result = number.ToString();

            return result;
        }
    }
}

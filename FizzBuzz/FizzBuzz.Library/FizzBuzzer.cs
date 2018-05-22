using System;

namespace FizzBuzz.Library
{
    public class FizzBuzzer
    {
        public static string FizzBuzz(int input)
        {
            var output = string.Empty;

            if (input % 3 == 0)
            {
                output = "Fizz";
            }

            if (input % 5 == 0)
            {
                output += "Buzz";
            }

            return string.IsNullOrEmpty(output) ? input.ToString() : output;
        }
    }
}

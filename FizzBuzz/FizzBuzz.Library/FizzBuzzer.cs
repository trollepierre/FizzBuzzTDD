using System;

namespace FizzBuzz.Library
{
    public class FizzBuzzer
    {
        public static string FizzBuzz(int input)
        {
            if (input % 5 == 0)
            {
                return "Buzz";
            }

            if (input % 3 == 0)
            {
                return "Fizz";
            }
            return input.ToString();
        }
    }
}

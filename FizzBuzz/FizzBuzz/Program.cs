﻿using System;
using FizzBuzz.Library;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i <= 100; i++)
            {
                Console.WriteLine(FizzBuzzer.FizzBuzz(i));
            }
            Console.ReadLine();
        }
    }
}

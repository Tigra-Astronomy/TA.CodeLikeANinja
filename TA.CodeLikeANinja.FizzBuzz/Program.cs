using System;
using TA.CodeLikeANinja.FizzBuzz.GameLogic;

namespace TA.CodeLikeANinja.FizzBuzz
{
    class FizzBuzzProgram
    {
        static void Main()
        {
            var gameLogic = new FizzBuzzer();
            for (int number = 1; number <= 100; ++number )
            {
                var fizzbuzz = gameLogic.ApplyGameRules(number);
                Console.WriteLine(fizzbuzz);
            }
        }
    }
}

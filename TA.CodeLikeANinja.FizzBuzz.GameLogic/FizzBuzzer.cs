using System;
using System.Collections.Generic;
using System.Text;

namespace TA.CodeLikeANinja.FizzBuzz.GameLogic
{
    public class FizzBuzzer
    {
        public string ApplyGameRules(int number)
        {
            bool isDivisibleByThree = number % 3 == 0;
            bool isDivisibleByFive = number % 5 == 0;
            if (isDivisibleByThree && isDivisibleByFive)
                return "FizzBuzz";
            if (isDivisibleByThree)
                return "Fizz";
            if (isDivisibleByFive)
                return "Buzz";
            return number.ToString();
        }
    }
}

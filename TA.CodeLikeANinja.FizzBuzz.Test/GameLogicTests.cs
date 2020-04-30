using Machine.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TA.CodeLikeANinja.FizzBuzz.GameLogic;

namespace TA.CodeLikeANinja.FizzBuzz.Test
{
    class when_the_number_is_not_divisible_by_3_or_5
    {
        private static FizzBuzzer unitUnderTest;
        private static string actual;
        private const string expected = "7";

        // Arrange
        Establish context = () => unitUnderTest = new FizzBuzzer();
        // Act
        Because of = () => actual = unitUnderTest.ApplyGameRules(7);
        // Assert
        It should_return_the_number_as_a_string = () => actual.ShouldEqual(expected);
    }

    class when_the_number_is_divisible_by_3
    {
        private static FizzBuzzer unitUnderTest;
        private static string actual;
        private const string expected = "Fizz";

        // Arrange
        Establish context = () => unitUnderTest = new FizzBuzzer();
        // Act
        Because of = () => actual = unitUnderTest.ApplyGameRules(3);
        // Assert
        It should_return_fizz = () => actual.ShouldEqual(expected);
    }

    class when_the_number_is_divisible_by_5
    {
        private static FizzBuzzer unitUnderTest;
        private static string actual;
        private const string expected = "Buzz";

        // Arrange
        Establish context = () => unitUnderTest = new FizzBuzzer();
        // Act
        Because of = () => actual = unitUnderTest.ApplyGameRules(5);
        // Assert
        It should_return_buzz = () => actual.ShouldEqual(expected);
    }

    class when_the_number_is_divisible_by_3_and_5
    {
        private static FizzBuzzer unitUnderTest;
        private static string actual;
        private const string expected = "FizzBuzz";

        // Arrange
        Establish context = () => unitUnderTest = new FizzBuzzer();
        // Act
        Because of = () => actual = unitUnderTest.ApplyGameRules(15);
        // Assert
        It should_return_fizzbuzz = () => actual.ShouldEqual(expected);
    }


}

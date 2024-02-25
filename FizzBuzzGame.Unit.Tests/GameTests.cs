using FizzBuzzGame.Models;
using FluentAssertions;
using System.Reflection.Metadata.Ecma335;

namespace FizzBuzzGame.Unit.Tests
{
    public class GameTests
    {
        [Theory]
        [InlineData("Fizz", 9)]
        [InlineData("Buzz", 10)]
        [InlineData("FizzBuzz", 15)]
        [InlineData("Fizz", 12)]
        [InlineData("Buzz", 35)]
        [InlineData("4", 4)]
        public void
             FizzBuzz_returns_fizz_for_the_number_divisible_by_three__returns_buzz_for_the_number_divisible_by_five_returns_FizzBuzz_for_the_number_divisible_by_five_and_three(string expected, int number)
        {
            var game = new Game();

            var actual = game.FizzBuzz(number);

            actual.Should().Be(expected);
        }
        [Fact]
        public void FizzBuzz_throws_NumberShouldNotBeLessThanZeroException_when_number_is_less_than_zero()
        {
            var number = -10;
            var game = new Game();

            var actual=()=>game.FizzBuzz(number);

            actual.Should().ThrowExactly<NumberShouldNotBeLessThanZeroException>();
        }
    }
}
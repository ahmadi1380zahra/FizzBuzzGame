
namespace FizzBuzzGame.Models
{
    public class Game
    {
        public string FizzBuzz(int number)
        {
            if (number <= 0)
            {
                throw new NumberShouldNotBeLessThanZeroException();
            }
            var res = number.ToString();
            if (number % 3 == 0 && number % 5 == 0)
            {
                res = "FizzBuzz";
            }
            else if (number % 3 == 0)
            {

                res = "Fizz";
            }
            else if (number % 5 == 0)
            {

                res = "Buzz";
            }
            return res;
        }
    }
}

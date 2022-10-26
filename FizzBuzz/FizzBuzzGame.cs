using System;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public string CountOff(int number)
        {
            if (number % 3 == 0)
            {
                return "Fizz";
            }

            return number.ToString();
        }
    }
}

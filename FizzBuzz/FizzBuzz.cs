using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public string GetString(int number)
        {
            string result = string.Empty;
            bool flag = false;

            if (number.ToString().Contains('3'))
            {
                return "Fizz";
            }
            else
            {
                if (number % 3 == 0)
                {
                    result += "Fizz";
                    flag = true;
                }

                if (number % 5 == 0)
                {
                    result += "Buzz";
                    flag = true;
                }

                if (number % 7 == 0)
                {
                    result += "Whizz";
                    flag = true;
                }
            }

            if (!flag)
            {
                result = number.ToString();
            }

            return result;
        }
    }
}

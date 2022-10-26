﻿namespace FizzBuzz
{
  public class FizzBuzzGame
  {
    public string CountOff(int number)
    {
      if (number % 3 == 0)
      {
        return "Fizz";
      }
      else if (number % 5 == 0)
      {
        return "Buzz";
      }
      else
      {
        return number.ToString();
      }
    }
  }
}

using System;

namespace StrategySample.Model 
{
  public class FizzBuzz : IFizzBuzzStrategy
  {
      public void PrintMessage(int? number) => Console.WriteLine("FizzBuzz");
      public bool Validate(int number) => number % 15 == 0;
  }
}
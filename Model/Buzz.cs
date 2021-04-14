using System;

namespace StrategySample.Model
{
  public class Buzz : IFizzBuzzStrategy
  {
    public void PrintMessage(int? number) => Console.WriteLine("Buzz");
    public bool Validate(int number) => number % 5 == 0;
  }
}
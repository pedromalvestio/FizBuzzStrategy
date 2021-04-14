using System;

namespace StrategySample.Model {
    public class Fizz : IFizzBuzzStrategy
    {
        public void PrintMessage(int? number) => Console.WriteLine("Fizz");
        public bool Validate(int number) => number % 3 == 0;
    }
}
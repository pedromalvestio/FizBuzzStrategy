
using System;

namespace StrategySample.Model {
    public class ShowNumber : IFizzBuzzStrategy
    {
        public void PrintMessage(int? number) => Console.WriteLine(number);

        public bool Validate(int number) => number % 15 != 0;
    }
}
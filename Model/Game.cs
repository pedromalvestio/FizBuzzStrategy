using System;
using System.Collections.Generic;
using System.Linq;

namespace StrategySample.Model { 
  public class Game : IGame
  { 
    private Dictionary<Func<int, bool>, Action<int?>> _fizzBuzzRules;

     public Game()
     {
          _fizzBuzzRules = new Dictionary<Func<int, bool>, Action<int?>>();
            var fizz = new Fizz();
            var buzz = new Buzz();
            var fizzBuzz = new FizzBuzz();
            var showNumber = new ShowNumber();

            _fizzBuzzRules.Add(fizzBuzz.Validate, fizzBuzz.PrintMessage);
            _fizzBuzzRules.Add(fizz.Validate, fizz.PrintMessage);
            _fizzBuzzRules.Add(buzz.Validate, buzz.PrintMessage);
            _fizzBuzzRules.Add(showNumber.Validate, showNumber.PrintMessage);
      }
      public void Play(int total)
      {
        for(var index = 1; index< total; index++ )
          _fizzBuzzRules.FirstOrDefault(f => f.Key(index)).Value?.Invoke(index);
      }
    }
}
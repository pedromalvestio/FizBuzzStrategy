namespace StrategySample.Model { 
    public interface IFizzBuzzStrategy {
        bool Validate(int number);
        void PrintMessage(int? number);
    }
}
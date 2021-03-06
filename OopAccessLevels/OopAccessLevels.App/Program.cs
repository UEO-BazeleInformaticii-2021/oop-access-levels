using OopAccessLevels.Library;
using System;

namespace OopAccessLevels.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            // private members of the Car NOT accessible here
            // car1.ECU

            // protected members of the Car NOT accessible here
            // car1.BodyStyle

            // internal members NOT accessible here
            // Console.WriteLine($"Car1 identification number: {car1.VIN}");

            // public members ARE accessible here
            Console.WriteLine($"Car1 registration number: {car1.RegistrationNumber}");

        }
    }
}

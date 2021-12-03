using System;

namespace OopAccessLevels.Library
{
    public class Parking
    {
        public void PrintDetailsOfTheCarsFromParking()
        {
            Car car1 = new Car();
            // private members of the Car NOT accessible here
            // car1.ECU

            // protected members of the Car NOT accessible here
            // car1.BodyStyle

            // internal members ARE accessible here
            Console.WriteLine($"Car1 identification number: {car1.VIN}");

            // public members ARE accessible here
            Console.WriteLine($"Car1 registration number: {car1.RegistrationNumber}");

        }
    }
}

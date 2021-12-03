using System;

namespace OopAccessLevels.Library
{
    public class Suv : Car
    {
        public void PrintSuvDetails()
        {
            // private members NOT accessible here
            // ECU = " Something else";
            // Console.WriteLine(ECU);

            // protected members ARE accessible here
            BodyStyle = "Suv";
            Console.WriteLine(BodyStyle);

            // internal members ARE accessible here
            Console.WriteLine($"Vehicle identification number: {VIN}");

            // public members ARE accessible here
            Console.WriteLine($"Registration number: {RegistrationNumber}");

        }
    }
}

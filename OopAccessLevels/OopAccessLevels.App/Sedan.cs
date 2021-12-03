using OopAccessLevels.Library;
using System;

namespace OopAccessLevels.App
{
    public class Sedan : Car
    {
        public void PrintSedanDetails()
        {
            // private members NOT accessible here
            // ECU = " Something else";
            // Console.WriteLine(ECU);

            // protected members ARE accessible here
            BodyStyle = "Sedan";
            Console.WriteLine(BodyStyle);

            // internal members NOT accessible here
            // Console.WriteLine($"Vehicle identification number: {VIN}");

            // public members ARE accessible here
            Console.WriteLine($"Registration number: {RegistrationNumber}");

        }
    }
}

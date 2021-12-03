using System;

namespace OopAccessLevels.Library
{
    public class Car
    {
        private string ECU = "A very important piece of the engine";
        protected string BodyStyle = "All";
        internal string VIN = "ABCD1323243";
        public string RegistrationNumber = "BH-01-ABC";

        public void PrintCarDetails()
        {
            // private members ARE accessible here
            ECU = " Something else";
            Console.WriteLine(ECU);

            // protected members ARE accesible here
            BodyStyle = "not set";

            // internal members ARE accessible here
            Console.WriteLine($"Vehicle identification number: {VIN}");

            // public members ARE accessible here
            Console.WriteLine($"Registration number: {RegistrationNumber}");
        }
    }
}

using CSharpTen.HelperClasses;
using CSharpTen.Helpers;
using RecordStructs.Structs;
using System;

namespace RecordStructs
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new();

            Vehicle secondVehicle = new(300, "Ferrari");

            Logger logger = new();
            logger.AddLoggingMessage(LoggerLevels.Error, $"This is an Error Loggin message made at {DateTime.UtcNow} ARRO");

            Console.WriteLine(vehicle);
            Console.WriteLine(secondVehicle);
        }
    }
}

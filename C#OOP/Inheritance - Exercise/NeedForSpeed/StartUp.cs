using System;

namespace NeedForSpeed
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            SportCar sportcar = new SportCar(300, 100);
            sportcar.Drive(10);
            Console.WriteLine(sportcar.Fuel);
        }
    }
}

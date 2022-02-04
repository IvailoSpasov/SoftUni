using System;

namespace GenericScale
{
   public class StartUp
    {
        static void Main(string[] args)
        {
            EqualityScale<int> IsNQqualToM = new EqualityScale<int>(4, 4);
            Console.WriteLine(IsNQqualToM.AreEqual());
        }
    }
}

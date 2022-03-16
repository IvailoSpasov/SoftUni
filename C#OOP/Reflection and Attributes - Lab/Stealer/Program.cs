using System;

namespace Stealer
{
   public class StarUp
   {
        static void Main(string[] args)
        {
            var spy = new Spy();
            var result = spy.CollectGetterAndSetters("Stealer.Hacker");
            Console.WriteLine(result);
        }
    }
}

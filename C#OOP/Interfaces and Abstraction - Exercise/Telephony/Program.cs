using System;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string[] urls = Console.ReadLine().Split();

            Smartphone phone = new Smartphone();

            for (int i = 0; i < numbers.Length; i++)
            {
                phone.Call(numbers[i]);
            }

            for (int i = 0; i < urls.Length; i++)
            {
                phone.Browse(urls[i]);
            }
            
        }
    }
}

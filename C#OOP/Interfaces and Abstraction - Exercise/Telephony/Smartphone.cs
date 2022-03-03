using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telephony
{
    public class Smartphone : ICallable, IBrowseble
    {
        public void Call(string number)
        {
            if (number.Any(x => char.IsLetter(x)))
            {
                Console.WriteLine("Invalid number!");
            }
            else if (number.Length == 10)
            {
                Console.WriteLine($"Calling... {number}");
            }
            else
            {
                Console.WriteLine($"Dialing... {number}");
            }
        }

        public void Browse(string url)
        {
            if (url.Any(x => char.IsDigit(x)))
            {
                Console.WriteLine("Invalid URL!");
            }
            else
            {
                Console.WriteLine($"Browsing: {url}!");
            }
        }
    }
}

using System;

namespace Square_Root
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double number = double.Parse(Console.ReadLine());
                double sqrt = Math.Sqrt(number);
                if (double.IsNaN(sqrt))
                {
                    throw new ArgumentException("Invalid number.");
                }
                Console.WriteLine(sqrt);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
        }

        
    }
}

using System;
using System.Text.RegularExpressions;

namespace Fancy_Barcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Regex regex = new Regex(@"@[#]+(?<product>[A-Z][A-Za-z0-9]{4,}[A-Z])@[#]+");
            for (int i = 0; i < n; i++)
            {
                string barcode = Console.ReadLine();
                Match match = regex.Match(barcode);
                if (regex.IsMatch(barcode))
                {
                    string currBarcode = match.ToString();
                    string digits = string.Empty;
                    for (int j = 0; j < currBarcode.Length; j++)
                    {
                        if (char.IsDigit(currBarcode[j]))
                        {
                            digits += currBarcode[j];
                        }
                    }

                    if (digits.Length == 0)
                    {
                        digits = "00";
                    }

                    Console.WriteLine($"Product group: {digits}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}

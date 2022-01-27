using System.IO;
using System.Linq;
using System.Text;

namespace EvenLines
{
    using System;
    public class EvenLines
    {
        static void Main(string[] args)
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder sb = new StringBuilder();
            StreamReader reader = new StreamReader(inputFilePath);
            int counter = 0;
            char[] symbuls = { '-', ',', '.', '!', '?' };
            while (true)
            {
                string result = reader.ReadLine();
                if (result == null) 
                {
                    break;
                }
                if (counter % 2 == 0)
                {
                    foreach (var symbul in symbuls)
                    {
                        result = result.Replace(symbul, '@');
                    }

                    result = string.Join(" ", result.Split().Reverse());
                    sb.AppendLine(result);
                }

                counter++;
            }

            return sb.ToString();
        }
        private static string ReverseWords(string replacedSymbols)
        {
            throw new NotImplementedException();
        }

        private static string ReplaceSymbols(string line)
        {
            throw new NotImplementedException();
        }
    }

}

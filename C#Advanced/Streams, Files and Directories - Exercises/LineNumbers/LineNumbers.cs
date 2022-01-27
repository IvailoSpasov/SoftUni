using System.IO;
using System.Linq;
using System.Text;

namespace LineNumbers
{
    using System;
    public class LineNumbers
    {
        static void Main(string[] args)
        {
            string inputPath = @"..\..\..\text.txt";
            string outputPath = @"..\..\..\output.txt";

            ProcessLines(inputPath, outputPath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            string[] lines = File.ReadAllLines(inputFilePath);
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < lines.Length; i++)
            {
                string text = lines[i];
                int numberOfLetters = text.Count(char.IsLetter);
                int numberOfPunctoations = text.Count(char.IsPunctuation);

                sb.AppendLine($"Line {i}: {text} ({numberOfLetters})({numberOfPunctoations})");
                //Line 3: -Quick, hide here. It is safer. (22)(4)

            }
            File.WriteAllText(outputFilePath,sb.ToString().TrimEnd());
        }
    }
}

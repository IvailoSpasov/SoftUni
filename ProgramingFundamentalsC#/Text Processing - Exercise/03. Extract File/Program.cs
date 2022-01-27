using System;

namespace _03._Extract_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] url = Console.ReadLine().Split("\\");
            string[] fileAndExtension = url[url.Length - 1].Split(".");
            string fileName = fileAndExtension[0];
            string fileExtension = fileAndExtension[1];
            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}

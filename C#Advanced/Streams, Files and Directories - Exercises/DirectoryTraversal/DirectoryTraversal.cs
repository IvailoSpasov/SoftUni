using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DirectoryTraversal
{
    using System;
    public class DirectoryTraversal
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            string[] files = Directory.GetFiles(inputFolderPath, "*");
            Dictionary<string, Dictionary<string, double>> filesInfo =
                new Dictionary<string, Dictionary<string, double>>();
            foreach (var file in files)
            {
                string fileName = Path.GetFileName(file);
                string extension = Path.GetExtension(file);
                double fileSize = new FileInfo(file).Length / 1024.0;
                if (!filesInfo.ContainsKey(extension))
                {
                    filesInfo.Add(extension, new Dictionary<string, double>());
                }
                filesInfo[extension].Add(fileName, fileSize);

            }

            StringBuilder sb = new StringBuilder();
            foreach (var kvp in filesInfo.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                sb.AppendLine(kvp.Key);
                foreach (var item in kvp.Value.OrderBy(x => x.Value))
                {
                    sb.AppendLine($"--{item.Key} - {item.Value:f3}kb");
                }
                //--Mecanismo.cs - 0.994kb
            }

            return sb.ToString().TrimEnd();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/report.txt";
            File.WriteAllText(path,textContent);
        }

    }
}

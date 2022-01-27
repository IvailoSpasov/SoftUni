using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split("-");
            Dictionary<string, int> results = new Dictionary<string, int>();
            Dictionary<string, int> submissions = new Dictionary<string, int>();

            while (input[0] != "exam finished")
            {
                string name = input[0];
                if (input[1] == "banned")
                {
                    results.Remove(name);
                }
                else
                {
                    string language = input[1];
                    int points = int.Parse(input[2]);
                    if (results.ContainsKey(name))
                    {
                        if (results[name] < points)
                        {
                            results[name] = points;
                        }
                    }
                    else
                    {
                        results.Add(name, points);
                    }

                    if (!submissions.ContainsKey(language))
                    {
                        submissions.Add(language, 0);
                    }

                    submissions[language]++;
                }
                input = Console.ReadLine().Split("-");
            }

            Console.WriteLine("Results:");
            foreach (var student in results.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var language in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }
        }
    }
}
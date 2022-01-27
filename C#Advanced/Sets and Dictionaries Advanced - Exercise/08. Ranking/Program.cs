using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] contests = Console.ReadLine().Split(":");
            Dictionary<string, string> contestsAndPasswords = new Dictionary<string, string>();
            while (contests[0] != "end of contests")
            {
                string contest = contests[0];
                string password = contests[1];

                if (!contestsAndPasswords.ContainsKey(contest))
                {
                    contestsAndPasswords.Add(contest, password);
                }
                contests = Console.ReadLine().Split(":");
            }

            string[] input = Console.ReadLine().Split("=>");
            Dictionary<string, Dictionary<string, int>> results = new Dictionary<string, Dictionary<string, int>>();
            while (input[0] != "end of submissions")
            {
                string contest = input[0];
                string password = input[1];
                string student = input[2];
                int points = int.Parse(input[3]);

                if (contestsAndPasswords.ContainsKey(contest) && contestsAndPasswords[contest] == password)
                {
                    if (!results.ContainsKey(student))
                    {
                        results.Add(student, new Dictionary<string, int>());
                    }

                    if (!results[student].ContainsKey(contest))
                    {
                        results[student].Add(contest, points);
                    }

                    else if (results[student][contest] < points)
                    {
                        results[student][contest] = points;
                    }
                }
                input = Console.ReadLine().Split("=>");
            }
            string bestCandidate = String.Empty;
            int totalPoints = 0;
            foreach (var candidate in results)
            {
                int currpoints = 0;
                foreach (var contest in candidate.Value)
                {
                    currpoints += contest.Value;
                }

                if (currpoints > totalPoints)
                {
                    bestCandidate = candidate.Key;
                    totalPoints = currpoints;
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidate} with total {totalPoints} points.");
            Console.WriteLine("Ranking:");
            foreach (var candidate in results.OrderBy(x => x.Key))
            {
                Console.WriteLine(candidate.Key);
                foreach (var contest in candidate.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
    }
}

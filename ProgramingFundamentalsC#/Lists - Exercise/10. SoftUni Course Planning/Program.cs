using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lesonsList = Console.ReadLine().Split(", ").ToList();
            string[] input = Console.ReadLine().Split(":").ToArray();

            while (input[0] != "course start")
            {
                string cmd = input[0];
                if (cmd == "Add")
                {
                    AddLessonToList(lesonsList, input[1]);
                }
                else if (cmd == "Insert")
                {
                    InsertLessonToList(lesonsList, input[1], int.Parse(input[2]));
                }
                else if (cmd == "Remove")
                {
                    RemoveLessonFromList(lesonsList, input[1]);
                }
                else if (cmd == "Swap")
                {
                    SwapLesonsFromList(lesonsList, input[1], input[2]);
                }
                else if (cmd == "Exercise")
                {
                    AddExerciseToList(lesonsList, input[1]);
                }

                input = Console.ReadLine().Split(":").ToArray();
            }

            for (int i = 0; i < lesonsList.Count; i++)
            {
                Console.WriteLine($"{i+1}.{lesonsList[i]}");
            }
        }

        private static void AddExerciseToList(List<string> lesonsList, string lessonExercise)
        {
            if (lesonsList.Contains(lessonExercise))
            {
                if (lesonsList.Contains($"{lessonExercise}-Exercise"))
                {
                    return;
                }
                else
                {
                    int index = lesonsList.IndexOf(lessonExercise);
                    lesonsList.Insert(index + 1, $"{lessonExercise}-Exercise");
                }
            }
            else
            {
                lesonsList.Add(lessonExercise);
                lesonsList.Add($"{lessonExercise}-Exercise");
            }
        }

        private static void SwapLesonsFromList(List<string> lesonsList, string lessonOne, string lessonTwo)
        {
            if (lesonsList.Contains(lessonOne) && lesonsList.Contains(lessonTwo))
            {
                int indexOne = lesonsList.IndexOf(lessonOne);
                int indexTwo = lesonsList.IndexOf(lessonTwo);
                lesonsList.RemoveAt(indexOne);
                lesonsList.Insert(indexOne, lessonTwo);
                lesonsList.RemoveAt(indexTwo);
                lesonsList.Insert(indexTwo, lessonOne);

                if (lesonsList.Contains($"{lessonOne}-Exercise"))
                {
                    lesonsList.Remove($"{lessonOne}-Exercise");
                    lesonsList.Insert(indexTwo + 1, $"{lessonOne}-Exercise");
                }

                if (lesonsList.Contains($"{lessonTwo}-Exercise"))
                {
                    lesonsList.Remove($"{lessonTwo}-Exercise");
                    lesonsList.Insert(indexOne + 1, $"{lessonTwo}-Exercise");
                }
            }
        }

        private static void RemoveLessonFromList(List<string> lesonsList, string lesson)
        {
            if (lesonsList.Contains(lesson))
            {
                lesonsList.Remove(lesson);
            }

            if (lesonsList.Contains($"{lesson}-Exercise"))
            {
                lesonsList.Remove($"{lesson}-Exercise");
            }
        }

        private static void InsertLessonToList(List<string> lesonsList, string lesson, int index)
        {
            if (!lesonsList.Contains(lesson))
            {
                lesonsList.Insert(index, lesson);
            }
        }

        private static void AddLessonToList(List<string> lesonsList, string lesson)
        {
            if (!lesonsList.Contains(lesson))
            {
                lesonsList.Add(lesson);
            }
        }
    }
}

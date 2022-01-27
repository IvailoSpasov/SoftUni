using System;

namespace Conditional_Statements___More_Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int poolVolume = int.Parse(Console.ReadLine());
            int firstPipeFlow = int.Parse(Console.ReadLine());
            int secondPipeFlow = int.Parse(Console.ReadLine());
            double hoursAway = double.Parse(Console.ReadLine());
            double totalLitersInPool = (firstPipeFlow + secondPipeFlow) * hoursAway;
            bool isThePoolFull = poolVolume >= totalLitersInPool;

            if (isThePoolFull)
            {
                double volumePercent = (totalLitersInPool / poolVolume) * 100;
                double firstPipeVolumeInPercent = ((firstPipeFlow * hoursAway) / totalLitersInPool) * 100;
                double secondPipeVolumeInPercent = ((secondPipeFlow * hoursAway) / totalLitersInPool) * 100;

                Console.WriteLine($"The pool is {volumePercent}% full. Pipe 1: {firstPipeVolumeInPercent}%. Pipe 2: {secondPipeVolumeInPercent}%.");

            }
            else
            {
                double overFlowlinLiters = ((firstPipeFlow + secondPipeFlow) * hoursAway) - poolVolume;

                Console.WriteLine($"For {hoursAway} hours the pool overflows with {overFlowlinLiters} liters.");
            }
        }
    }
}

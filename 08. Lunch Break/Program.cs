namespace _08._Lunch_Break
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string seriesName = Console.ReadLine();
            int seriesDuration = int.Parse(Console.ReadLine());
            int breakDuration = int.Parse(Console.ReadLine());

            double timeForLunch = breakDuration / 8.0;
            double timeForBreak = breakDuration / 4.0;

            double restTime = breakDuration - timeForBreak - timeForLunch;

            if (seriesDuration <= restTime)
            {
                Console.WriteLine($"You have enough time to watch {seriesName} and left with {Math.Ceiling(restTime - seriesDuration)} minutes free time.");
            }
            else
            {
                Console.WriteLine($"You don't have enough time to watch {seriesName}, you need {Math.Ceiling(seriesDuration - restTime)} more minutes.");
            }
        }
    }
}
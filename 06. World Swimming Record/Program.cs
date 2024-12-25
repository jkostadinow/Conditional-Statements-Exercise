namespace _06._World_Swimming_Record
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double wordRecord = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());

            double totalTime = distance * secondsPerMeter;
            double delay = Math.Floor(distance / 15) * 12.5;
            double finalTime = totalTime + delay;

            if (finalTime < wordRecord)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {finalTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {(finalTime - wordRecord):f2} seconds slower.");
            }


        }
    }
}
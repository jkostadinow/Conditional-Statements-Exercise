namespace _03._Time___15_Minutes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int hour = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine()) + 15;

            if (minutes > 59)
            {
                hour = hour + 1;
                minutes =0 + (minutes - 60);
                
            }
            if (hour >23)
            {
                hour = 0;
            }
            if (minutes < 10)
            {
                Console.WriteLine($"{hour}:0{minutes}");
            }
            else
            {
                Console.WriteLine($"{hour}:{minutes}");
            }
           

        }
    }
}
namespace _07._Shopping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfVideoAdapters = int.Parse(Console.ReadLine());
            int numberOfProcessors = int.Parse(Console.ReadLine());
            int numberOfRamMemory = int.Parse(Console.ReadLine());

            double priceVideoAdapters = numberOfVideoAdapters * 250;
            double priceProcessors = numberOfProcessors * priceVideoAdapters * 0.35;
            double priceRamMemory = numberOfRamMemory * priceVideoAdapters * 0.10;

            double totalCosts = priceVideoAdapters + priceProcessors + priceRamMemory;

            if (numberOfVideoAdapters > numberOfProcessors)
            {
                totalCosts = totalCosts - totalCosts * 0.15;
            }
            if (budget >= totalCosts)
            {
                Console.WriteLine($"You have {(budget - totalCosts):f2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {(totalCosts - budget):f2} leva more!");
            }
        }
    }
}
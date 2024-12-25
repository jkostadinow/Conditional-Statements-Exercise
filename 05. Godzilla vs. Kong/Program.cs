namespace _05._Godzilla_vs._Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfExtras = int.Parse(Console.ReadLine());
            double clothingPrice = double.Parse(Console.ReadLine());

            double decor = budget * 0.10;
            double costsForClothing = numberOfExtras * clothingPrice;

            if (numberOfExtras > 150)
            {
                costsForClothing = costsForClothing - costsForClothing * 0.10;
            }

            double totalCosts = decor + costsForClothing;

            if (totalCosts > budget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {(totalCosts - budget):f2} leva more.");
            }
            else if (totalCosts <= budget)
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {(budget - totalCosts):f2} leva left.");
            }


        }
    }
}
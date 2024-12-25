namespace _04._Toy_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
           double tripPrice = double.Parse(Console.ReadLine());

            int puzzlesQuantity = int.Parse(Console.ReadLine());
            int dollsQuantity = int.Parse(Console.ReadLine());
            int bearsQuantity = int.Parse(Console.ReadLine());
            int minionsQuantity = int.Parse(Console.ReadLine());
            int trucksQuantity = int.Parse(Console.ReadLine());

            int totalQuantity = puzzlesQuantity + dollsQuantity + bearsQuantity + minionsQuantity + trucksQuantity;

            double totalPricePuzzles = puzzlesQuantity * 2.60;
            double totalPriceDolls = dollsQuantity * 3;
            double totalPriceBears = bearsQuantity * 4.10;
            double totalPriceMinions = minionsQuantity * 8.20;
            double totalPriceTrucks = trucksQuantity * 2;

            double totalProfit = totalPricePuzzles + totalPriceDolls + totalPriceBears + totalPriceMinions + totalPriceTrucks;

            if (totalQuantity >= 50)
            {
                totalProfit = totalProfit - totalProfit * 0.25;

            }
            totalProfit = totalProfit - totalProfit * 0.10;

            if (totalProfit >= tripPrice)
            {
                Console.WriteLine($"Yes! {(totalProfit - tripPrice):f2} lv left.");
            }
            else  
            {
                Console.WriteLine($"Not enough money! {Math.Abs(totalProfit - tripPrice):f2} lv needed.");
            }
           
              
        }
    }
}
namespace exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());

            double result = num1 / num2;
            Console.WriteLine(result);
        }
    }
}
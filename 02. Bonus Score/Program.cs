namespace _02._Bonus_Score
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            double bonus = 0.0;
            double sum = 0.0;
            
            if (num > 1000)
            {
                bonus = num * 0.10;
                sum = bonus + num;

                if (num % 2 == 0)
                {
                    bonus += 1;
                    sum = bonus + num;
                }
                else if (num % 5 == 0)
                {
                    bonus += 2;
                    sum = bonus + num;
                }
            }
            else if (num <= 100)
            {
                 bonus = 5;
                 sum = bonus + num;


                if (num % 2 == 0)
                {
                    bonus += 1;
                    sum = bonus + num;
                }
                else if (num % 5 == 0)
                {
                    bonus += 2;
                    sum = bonus + num;
                }
            
            }
            else if  (num > 100)
            {
                bonus = num * 0.2;
                sum = num + bonus;

                if (num % 2 == 0)
                {
                    bonus += 1;
                    sum = num + bonus;
                    
                }
                else if (num % 10 == 5)
                {
                    bonus += 2;
                    sum = bonus + num;
                }
            }
            
            Console.WriteLine(bonus);
            Console.WriteLine(sum);
        }
    }
}
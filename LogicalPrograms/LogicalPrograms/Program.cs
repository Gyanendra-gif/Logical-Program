using System;

namespace LogicalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Enter your Choice Number to Execute the Logical Program Press- 1-Fibonacci Series, 2-Perfect Number, 3-Prime Number, 4-Reverse Number, 5-Coupan Number, 6-Stopwatch Program, 7-Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the length of the Fibonacci Series: ");
                        int length = Convert.ToInt32(Console.ReadLine());
                        FibonacciSeries fc = new FibonacciSeries();
                        fc.Series(length);
                        break;
                    case 2:
                        Console.Write("Enter the number :");
                        int number = Convert.ToInt32(Console.ReadLine());
                        PerfectNumber pn = new PerfectNumber();
                        pn.Check(number);
                        break;
                    case 3:
                        Console.WriteLine("Enter the Number to Check it's a Prime Number or not");
                        int num = Convert.ToInt32(Console.ReadLine());
                        PrimeNumber prn = new PrimeNumber();
                        prn.Check(num);
                        break;
                    case 4:
                        Console.WriteLine("Enter a Number to Reverse ");
                        int numb = Convert.ToInt32(Console.ReadLine());
                        ReverseNumber rv = new ReverseNumber();
                        rv.Calculation(numb);
                        break;
                    case 5:
                        flag = false;
                        break;
                }
            }
        }
    }
}
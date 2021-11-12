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
                        fc.series(length);
                        break;
                    case 2:
                        flag = false;
                        break;
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace LogicalPrograms
{
    class PrimeNumber
    {
        public void Check(int num) 
        {
            for (int i = 2; i < num; i++) 
            {
                if (num % 2 == 1) 
                {
                    Console.WriteLine("The Given Number is Prime Number");
                    break;
                }
                else 
                {
                    Console.WriteLine("The Given Number is Not a Prime Number");
                    break;
                }
            }
        }
    }
}

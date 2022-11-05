using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1_ShravanKumar_Project8
{
    public class PrimeNumber
    {
        public int iterator;
        bool prime = true;
        public PrimeNumber(int number)
        {
            for (int j = 2; j <= number / 2; j++)
            {
                if (number % j == 0)
                {
                    prime = false;
                    break;
                }
            }

            if (prime)
            {
                Console.WriteLine("prime");
            }
            else
            {
                Console.WriteLine("Not prime");
            }
        }
    }
}

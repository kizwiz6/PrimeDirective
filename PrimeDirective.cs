using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeDirective
{
    public class PrimeDirective
    {
        public bool isPrime(int number)
        {
            if (number == 2)
            {
                return true;
            }
            else if (number < 2)
            {
                return false;
            }

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public List<int> OnlyPrimes(int[] numbers)
        {
            List<int> primes = new List<int>();

            foreach (int num in numbers)
            {
                if (isPrime(num))
                {
                    primes.Add(num);
                }
            }
            return primes;
        }
    }
}

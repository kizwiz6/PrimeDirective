using System.Collections;
using System.Numerics;
using System.Collections.Generic;

namespace PrimeDirective
{
    public class Program
    {
        static void Main(string[] args)
        {
            PrimeDirective pd = new PrimeDirective();
            Console.WriteLine(pd.isPrime(6));

            int[] numbers = { 6, 29, 28, 33, 11, 100, 101, 43, 89 };

            Console.WriteLine("List of numbers and their primality:");
            foreach (int num in numbers)
            {
                bool isPrime = pd.isPrime(num);
                Console.WriteLine($"{num}: {(isPrime ? "Prime" : "Not Prime")}");
            }

            List<int> primes = pd.OnlyPrimes(numbers);

            Console.WriteLine("\nList of prime numbers:");
            foreach (int prime in primes)
            {
                Console.WriteLine(prime);
            }
        }
    }
}
namespace PrimeDirective
{
    internal class PrimeDirective
    {
        public bool isPrime(int number)
        {
            if(number == 2)
            {
                return true;
            }
            else if(number < 2)
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


        static void Main(string[] args)
        {
            PrimeDirective pd = new PrimeDirective();
            Console.WriteLine(pd.isPrime(6));
        }
    }
}
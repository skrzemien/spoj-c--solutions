using System;


namespace spoj
{
    internal class Program
    {
        private static bool PrimeTest(int PrimeNumber)
        {
            if (PrimeNumber < 2)
                return false;
            for (int i = 2; i < (PrimeNumber/2)+1; i++)
            {
                if (PrimeNumber % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {           
            string InputToPrimesCount = Console.ReadLine();
            Int32.TryParse(InputToPrimesCount, out int PrimesCount);
            int[] ArrayOfPrimes = new int[PrimesCount];
            for (int i = 0; i < PrimesCount; i++)
            {
                string InputPrimeNumber = Console.ReadLine();
                Int32.TryParse(InputPrimeNumber, out int PrimeNumber);
                ArrayOfPrimes[i] = PrimeNumber;
            }
            foreach (int PrimeNumber in ArrayOfPrimes)
            {
                if (PrimeTest(PrimeNumber) == true)
                    Console.WriteLine("TAK");
                else
                    Console.WriteLine("NIE");
            }

            Console.ReadLine();

        }
    }
}

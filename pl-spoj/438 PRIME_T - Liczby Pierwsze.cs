using System;


namespace spoj
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            string InputNumbersCount = Console.ReadLine();
            Int32.TryParse(InputNumbersCount, out int NumbersCount);
            int[] ArrayOfNumbers = new int[NumbersCount];
            for (int i = 0; i < NumbersCount; i++)
            {
                string InputNumber = Console.ReadLine();
                Int32.TryParse(InputNumber, out int Number);
                ArrayOfNumbers[i] = Number;
            }
            foreach (int Number in ArrayOfNumbers)
            {
                if (IsNumberPrime(Number) == true)
                    Console.WriteLine("TAK");
                else
                    Console.WriteLine("NIE");
            }
            Console.ReadLine();
        }
        private static bool IsNumberPrime(int Number)
        {
            if (Number < 2)
                return false;
            for (int i = 2; i < (Number / 2) + 1; i++)
            {
                if (Number % i == 0)
                    return false;
            }
            return true;
        }
    }
}

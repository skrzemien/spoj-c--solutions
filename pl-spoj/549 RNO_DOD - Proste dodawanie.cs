using System;
using System.Linq;

namespace spoj
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            string InputTestsNumber = Console.ReadLine();
            Int32.TryParse(InputTestsNumber, out int TestsNumber);
            for (int i = 1; i <= TestsNumber; i++)
            {
                string InputNumbersCount = Console.ReadLine();
                Int32.TryParse(InputNumbersCount, out int NumbersCount);
                int[] ArrayOfNumbers = new int[NumbersCount];
                for(int j = 0; j < NumbersCount; j++)
                {
                    string InputNumber = Console.ReadLine();
                    Int32.TryParse(InputNumber, out int Number);
                    ArrayOfNumbers[j] = Number;
                }
                Console.WriteLine(ArrayOfNumbers.Sum());
            }
            Console.ReadLine();
        }       
    }
}

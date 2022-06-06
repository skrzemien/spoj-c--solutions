using System;


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
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }       
    }
}

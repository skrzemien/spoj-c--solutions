using System;


namespace spoj
{
    internal class Program
    {
        static void Main(string[] args)
        {           
            string InputFirstNumber = Console.ReadLine();
            Int32.TryParse(InputFirstNumber, out int FirstNumber);
            string InputSecondNumber = Console.ReadLine();
            Int32.TryParse(InputSecondNumber, out int SecondNumber);
            Console.WriteLine(FirstNumber+SecondNumber);
            Console.ReadLine();
        }       
    }
}

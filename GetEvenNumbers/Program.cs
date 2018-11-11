using System;
using System.Linq;

namespace GetEvenNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The numbers which produce reminder 0 after divided by 2 are:");
            int[] table = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var even = from numbers in table
                       where (numbers % 2 == 0)
                       select numbers;

            foreach (var numbers in even)
            {
                Console.WriteLine("{0}", numbers);
            }
            
            Console.ReadKey();
        }
    }
}

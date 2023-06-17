using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pSolves
{
    internal class FindAnyValue
    {
        internal void PrintMethod()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            Console.Write("Original Array: ");
            for(int number = 0; number<numbers.Length-1; number++)
            {
                Console.Write(numbers[number]);
            }
            Console.WriteLine(); // for break line

            Console.Write("Printing Second indice value : ");
            Console.WriteLine($" {numbers[1]} ");

            Console.Write("Print first indice value : ");
            Console.WriteLine($" {numbers[0]}");

            Console.Write("Print last indice value : ");
            Console.WriteLine($" {numbers[4]}");

            Console.WriteLine("Print except first and last values: ->");
            Console.WriteLine($"[1] - {numbers[1]}");
            Console.WriteLine($"[2] - {numbers[2]}");
            Console.WriteLine($"[3] - {numbers[3]}");


        }
    }

        internal class SomeValueArray
        {
            static void Main(string[] args)
            {
                // instance of an printanotherclass
                var obj1 = new FindAnyValue();
                obj1.PrintMethod();
                Console.ReadLine();
            }
        }
    
}

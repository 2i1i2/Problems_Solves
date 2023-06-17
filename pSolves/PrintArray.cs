using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pSolves
{
    internal class PrintAnotherClass
    {
        internal void PrintMethod()
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5 };

            Console.Write("Printing Array: ");
            foreach ( var item in numbers)
            {
                Console.Write($" {item} ");
            }
        }
    }
    internal class PrintArray
    {
        static void Main(string[] args)
        {
            // instance of an printanotherclass
            var obj1 = new PrintAnotherClass();
            obj1.PrintMethod();
            Console.ReadLine();
        }
    }
}

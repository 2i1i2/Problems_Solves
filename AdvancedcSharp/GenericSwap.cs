using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedcSharp
{
    internal class GenericSwap
    {
        static void Main(string[] args)
        {
            string a = "abc";
            string b = "xyz";
            Console.WriteLine($"{a} {b}");
            SwapGenericMethod<string>(ref a,ref b);
            Console.WriteLine($"{a} {b}");
            Console.ReadLine();
        }


        static void SwapGenericMethod<T>(ref T a,ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pSolves
{

    internal class ReverseArrayClass
    {
        public void ReverseArrayMethod(int[] arr, int start, int end)
        {
            int temp = 0;
            while(start < end)
            {
                temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }

        public void PrintMethod(int[] arr, int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write("{0} ", arr[i]);
            }

            Console.WriteLine();
        }
    }

    internal class ReverseArray
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[] { 1, 2, 3, 4, 5};
            int size = array1.Length;

            // create an instance
            var obj = new ReverseArrayClass();
            Console.Write("Simple Array >>  ");
            obj.PrintMethod(array1, 5);
            obj.ReverseArrayMethod(array1, 0, 4);
            Console.Write("Reverse Array >>  ");
            obj.PrintMethod(array1, 5); 
            Console.ReadLine();
        }
    }
}

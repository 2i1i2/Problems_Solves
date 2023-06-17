using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pSolves
{
    internal class ReverseString
    {
        public string ReverseStringMethod(string str)
        {
            // making charArray
            char[] charArray = str.ToCharArray();

            string emptyArray = String.Empty;

            // interating every character with loop
            for (int i = str.Length-1 ; i > -1; i--)
            {
                emptyArray += charArray[i];
            }

            return emptyArray;
        }
    }
    internal class MainClass
    {
        static void Main(string[] args)
        {
            var obj = new ReverseString();
            Console.WriteLine("Simple String >> Welcome");
            Console.WriteLine("Reverse String >> {0}",obj.ReverseStringMethod("Welcome"));
            Console.ReadLine();
        }
    }
}

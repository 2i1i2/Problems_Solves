using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedcSharp
{
    internal class Extension
    {
        static void Main(string[] args)
        {
            string str = "This is suppose to very long string";
            var shortString = str.Shorten(5);
            Console.WriteLine(shortString);
            Console.ReadLine();
        }


    }
    public static class StringExtension
    {
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords < 0)
                throw new ArgumentOutOfRangeException("numberOfRange should be greater than or equal to 0.");
            if (numberOfWords == 0)
                return "";
            var words = str.Split(' ');
            if (words.Length <= numberOfWords)
                return str;

            return string.Join(" ", words.Take(numberOfWords));
        }
    }
}

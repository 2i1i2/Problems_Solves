using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedcSharp
{
    internal class DictonaryExample
    {
        static void Main(string[] args)
        {
            // creatin a dictonary with key and value both are string type
            Dictionary<string, string> dcountry = new Dictionary<string, string>();

            // creating a dictoanry with key and vlaue both are collection Initializers
            Dictionary<string, string> daction = new Dictionary<string, string>
            {
                {"1","Hight" },
                {"2","Medums" },
                {"3", "Low" }
            };



            // adding elements using dictonary using add method of dictonary class
            dcountry.Add("IN", "India");
            dcountry.Add("UK", "United State");


            Console.WriteLine();
            // Accessing elements using foreach loop
            foreach (var KVP in dcountry)
            {
                Console.WriteLine($"Key: {KVP.Key} Value: {KVP.Value} ");
            }


            Console.WriteLine(); /// terminate for new line
            // Accessing elements using for loops
            for (int i = 0; i < dcountry.Count; i++)
            {
                string key = dcountry.Keys.ElementAt(i);
                string value = dcountry[key];
                Console.WriteLine($"Key: {key} Value: {value} ");
            }


            Console.WriteLine(); // for terminate the line
            // Accessing elements using foreach loop
            foreach (var levels in daction)
            {
                Console.WriteLine($"Level: {levels.Key} Value: {levels.Value} ");
            }


            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace AdvancedcSharp
{
    /* HashTable is non-generic collection that stores key-value paris, similar to generic Dictonary<TKey, TValue> collection.
     * HashTable stores key-value paris.
     * Implementations IDictonary interface
     * Keys must be unique and cannot be null.
     * Values can be null or duplicate.
     * 
     */
    internal class HashTables
    {
        static void Main(string[] args)
        {
            // Creating HashTable and Add Elements
            Hashtable numberNames = new Hashtable();
            numberNames.Add(1, "One");
            numberNames.Add(2, "Two");


            // reterive every elements
            foreach(DictionaryEntry d in numberNames)
            {
                Console.WriteLine($"{d.Key} {d.Value}");
            }

            // creating a hashtable using collection interation initilizer syntax
            var namemyfamily = new Hashtable()
            {
                {1, "4ishi9a5" },
                {2,"U0ha" }
            };

            foreach (DictionaryEntry n in namemyfamily)
                Console.WriteLine($"{n.Value}");

            Console.ReadLine();
        }


    }
}

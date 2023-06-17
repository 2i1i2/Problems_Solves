using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace LinqSyntax
{

    /// <summary>
    /// Q. Linq Query
    /// -Data Source
    /// -Query
    /// -Execution of Query
    /// 
    /// Q. What is Query?
    /// -Initialization Syntax
    /// -Method Syntax
    /// -Mixed Syntax
    /// 
    /// 
    /// </summary>




    
    internal class DifferentWayLinqQuery
    {
        static void Main(string[] args)
        {
            // Step 1: Data Source
            List<int> integerList = new List<int>()
            {
                1,2,3,4,5,6,7,8,9,10
            };

            //Step 2: Query
            // linq query syntax
            var result = from obj in integerList // data source
                         where obj > 5 && obj < 10 // condition
                         select obj; // selection



            // linq query method
            var result2 = integerList.Where(obj => obj > 1 && obj < 10).ToList();

            Console.Write("Query Syntax: ");
            // Step 3: Execution
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            Console.Write("Query Syntax Method: ");  // terminat line
            // print query method
            foreach (var item in result2)
            {
                Console.Write(item + " ");
            }

            //for break line
            Console.WriteLine();
            // linq query using method syntax
            var result3 = (from obj in integerList
                           where obj > 5
                           select obj).Sum();


            Console.WriteLine("Query Syntax using method: ");
            foreach(var item in result3.ToString())
            {
                Console.Write($"{item}");
            }
            Console.ReadLine();
        }
    }
}

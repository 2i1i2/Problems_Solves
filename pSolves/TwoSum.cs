
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pSolves
{
    /// <summary>
    /// Question 1: Given an array of intergers return the indices of the two numbers that add up to a given target.
    //    like[1, 3, 7, 9] target = 11

    //Ans: 
    //  step: 1 Verify the constraints
    //	    1) - Are all the numbers positive or there can be negative?
    //	    1) - All the numbers are positive.

    //	    2) - Are there duplicate numbers in the array?
    //	    2) - No, there are no duplicates.

    //  	3) - Will there always be a solution available?
    //	    3) - No, there may not always be a solution.

    //	    4) - What do we return if there not solution?
    //	    4) - just return null.

    //	    5) - Can there be multiple pairs that add up to the target?
    //	    5) - No, only 1 pairs of numbers will add up to the target.
    //  
    //
    //  step: 2 Write out some test cases
    //      [1,3,7,9,2]  t = 11     [3,4]
    //      [1,3,7,9,2]  t = 25     null
    //      []           t = 1      null
    //      [5]          t = 5      null
    //      [1,6]        t = 7      [0,1]
    //
    //  step: 3 Figure out a solution without code
    //      nums = [ 1,3,7,9,2]  target = 11
    //      nums.length = 5
    //      first loop > p1 = 0 to nums.length-1
    //      findNum = target - nums[p1]
    //      second loop > p2 = p1+1 to nums.length-1
    //      
    //      logic
    //      
    //      if(findNum == nums[p2]
    //      return p1, p2
    //      otherwise
    //      return null
    //
    //
    //      
    //  step: 4 Write out some solution in code
    //      
    //    function findNumFunction(int[] array, target){
    //   for(int p1 = 0; p1<arrray.length-1; p1++){
    //          int findNum = target - num[p1];
    //       for(int p2 = p1+1;  p2.array.length-1; p2++) {
    //           if(findNum == array[p2]) {
    //                return p1, p2
    //}
    //       }
    //   }
    //}   
    //   main() {
    //  int array = [ 1,3,7,9,2]
    //  target = 11
//}
//
//


    /// </summary>
    internal class TwoSumClass
    {
        public static int[] TwoSumMethod(int[] arr , int target)
        {
            var map = new Dictionary<int, int>();
            for (int p1 = 0; p1 < arr.Length; p1++)
            {
                var key = target - arr[p1];
                if(map.ContainsKey(key))
                {
                    return new int[] { map[key], p1};
                }
                map.Add(arr[p1], p1);
            }
            return null;
           
        }
    }
    internal class TwoSumMain
    {
        /// <param name="args"></param>    
        static void Main(string[] args)
        {
            // instance of twosum class
            var obj = new TwoSumClass();
            int[] array = new int[] { 1, 2, 3, 4, 5 };
            const int target = 9;

            var ts = TwoSumClass.TwoSumMethod(array, target);
            Console.WriteLine(ts != null ? $"{ts[0]}, {ts[1]}" : "no result");
            Console.ReadLine();
        }
    }
}

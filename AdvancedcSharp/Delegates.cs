using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedcSharp
{

    // Declare a delegate
    public delegate void MyDelegate(string msg);
    internal class Delegates
    {
        static void Main(string[] args)
        {
            // Set the target method
            MyDelegate del = ClassA.MehtodA;
            del("Hello Delegagte.");

            // or
            del("Hello Or Delegate");

            del = ClassB.MethodB;
            del("ClassB");

            // lambda expression
            del = (string msg) => Console.WriteLine("Called lambda expression" + msg);

            Console.ReadLine();
        }
    }

    internal class ClassA
    {
        public static void MehtodA(string message)
        {
            Console.WriteLine("Method A from Class A {0}", message);
        }
    }

    internal class ClassB
    {
        public static void MethodB(string message)
        {
            Console.WriteLine("Method B from Class B {0}", message);
        }
    }
}

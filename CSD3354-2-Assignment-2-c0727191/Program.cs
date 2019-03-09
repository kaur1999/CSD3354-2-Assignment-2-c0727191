using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bableen Kaur(c0727191)
//Shingarjeet Singh(c0731902)
//CSD3354 section3
//Assignment 2
// March6, 2019
namespace CSD3354_2_Assignment_2_c0727191
{
    using System;
    delegate void ExampleDelegate(String xyz);


    class Program
    {
        public static void Method1(String xyz)
        {
            Console.WriteLine(xyz + " Method 1");
        }
        public static void Method2(String xyz)
        {
            Console.WriteLine(xyz + " Method 2");
        }
        public static void Main()
        {
            ExampleDelegate ex1Delegate, ex2Delegate, ex3Delegate,
myDelegate;
            ex1Delegate = new ExampleDelegate(Method1);
            ex2Delegate = new ExampleDelegate(Method2);
            ex3Delegate = ex1Delegate + ex2Delegate;
            myDelegate = ex1Delegate - ex2Delegate;
            ex1Delegate("AAA");
            ex2Delegate("BBB");
            ex3Delegate("CCC");
            myDelegate("DDD");
            myDelegate = ex3Delegate - ex1Delegate;
            myDelegate("EEE");
            myDelegate = ex3Delegate - ex2Delegate;
            myDelegate("FFF");
            Console.ReadLine();



        }

    }

}





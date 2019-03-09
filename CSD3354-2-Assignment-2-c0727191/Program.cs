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
    public class program
    {
        public static void Main()
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method3();
            Console.ReadLine();
        }
    }
    public class DelegateExercises
    {
        public delegate int MyDelegate(int intvalue);
        int Method1(int intMethod1)
        {
            return intMethod1 * 2;
            return intMethod1 * 4;
        }
        int Method2(int intMethod1)
        {
            return intMethod1 * 10;
            return intMethod1 * 20;
        }
        public void Method4(MyDelegate myDelegate)
        {
            int result = myDelegate(10);
            Console.WriteLine(result);
            for (int i = 1; i <= 5; i++)
                System.Console.Write(myDelegate(i) + " ");
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            Method4(myDelegate);

            myDelegate = new MyDelegate(Method2);
            Method4(myDelegate);

        }
    }
}
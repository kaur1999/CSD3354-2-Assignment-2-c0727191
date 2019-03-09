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

    public class Program
    {
        private static void Main()
        {
            DelegateExcercises delegateExcercises = new DelegateExcercises();
            delegateExcercises.Method3();
            Console.ReadLine();
        }
    }
    public delegate void MyDelegate();

    public class DelegateExcercises
    {

        void Method1()
        {
            System.Console.WriteLine("Method1");
        }
        public void Method3()
        {
            MyDelegate myDelegate = new MyDelegate(Method1);
            myDelegate();
            System.Console.WriteLine(myDelegate.ToString());
        }

    }
}


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
    public class DelegateExercises
    {

        public delegate void MyDelegate();
        void Methodl(int i)
        {

            Console.WriteLine("Method1");
            Console.ReadLine();
        }

        public void Method2()
        {
            MyDelegate myDelegate = new MyDelegate(Methodl);
            myDelegate();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DelegateExercises delegateExercises = new DelegateExercises();
            delegateExercises.Method2();
        }
    }
}
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
            {
                DelegateExercises delegateExercises = new DelegateExercises();
                delegateExercises.Method3();
                Console.ReadLine();
            }
        }
        public delegate int MyDelegate(out int i);
        public class DelegateExercises
        {
            int Method1(out int i)
            {
                System.Console.WriteLine("Method1");
                i = 10;
                return 0;
            }
            public void Method3()
            {
                MyDelegate myDelegate = new MyDelegate(Method1);
                MyDelegate myDelegate1 = new MyDelegate(Method1);
                MyDelegate myDelegate2 = myDelegate + myDelegate1;
                int intValue;
                myDelegate2(out intValue);
            }


        }
    }
}




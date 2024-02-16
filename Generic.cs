using System;

namespace Demo
{


    class GenericApplication
    {

        public static void Main(string[] args)
        {

            Sum(1, 2);
            Sum(3, 3.4444);




        }

        public static void Sum<T>(T a, T b)
        {


            Console.WriteLine(a + b);


            Console.WriteLine($"{a} and {b}");




        }
    }
}
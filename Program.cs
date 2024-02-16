using System;
using DemoNamespace;




namespace MyApp
{
    internal class Program
    {

        int x;

        Program()
        {
            Console.WriteLine(" Default Constructor called");
            this.x = 20;
        }

        Program(int a)
        {
            Console.WriteLine(" Parameterize Constructor called");
            this.x = 20;
        }

        Program(int a, int b)
        {
            Console.WriteLine(" Parameterize Constructor  with 2 argumnet called");

            this.x = a + b;
        }

        int func()
        {
            return x;
        }


        static void Main(string[] args)
        {

            Program obj = new Program();
            Program obj2 = new Program(1);
            Program obj3 = new Program(1, 2);

            Console.WriteLine(obj.func());

            Demo.fun();

            // string firstname = "Lokesh";
            // string lastname = "Gawande";
            // string full_name = $"Full Name is {firstname} {lastname}";
            // Console.WriteLine(full_name);

            // int x = 21;
            // string ans = (x % 2 == 0) ? "even" : "odd";
            // Console.WriteLine($"The number is {ans}");

            // int[] arr = { 1, 2, 3, 4, 5, 1, 2, 3 };
            // int[,] twod = { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            // Console.WriteLine(twod[0, 1]);
            // Array.Sort(arr);

            // for (int i = 0; i < arr.Length; i++)
            // {
            //     Console.Write(arr[i]);
            // }






            // string s = "Hello";
            // Console.WriteLine(s.Length);
            // Console.WriteLine(s.Substring(0, s.Length - 1));
            // Console.WriteLine(s.ToUpper());
            // Console.WriteLine(s.ToLower());

            // int x;

            // Console.WriteLine(Math.Max(2, 3));
            // Console.WriteLine("Enter Number");
            // x = Convert.ToInt32(Console.ReadLine());
            // if (x % 2 == 0)
            // {
            //     Console.WriteLine("The number " + x + " is even.");

            // }
            // else
            // {
            //     Console.WriteLine("The number " + x + " is odd.");

            // }

        }
    }
}
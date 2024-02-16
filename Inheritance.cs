using System;

namespace OOOPS
{

    class Parent
    {

        public int x;

        public Parent()
        {
            x = 0;
            Console.WriteLine($"Parent class called {x}");
        }

    }


    class Child : Parent
    {


        public Child()
        {
            x = 10;
            Console.WriteLine($"Child class called {x}");

        }
    }

    class MainClass
    {
        static void Main(string[] args)
        {

            Child ch1 = new Child();
            // Child ch2 = new Parent();

        }

    }









}
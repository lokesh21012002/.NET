using System;

namespace Abstract
{
    abstract class AbstractClass
    {


        public int x;


        public abstract void set_x(int val);





    }

    class MainClass : AbstractClass
    {

        string name = "Lokesh";

        public override void set_x(int y)
        {
            x = y;

        }

        public override string ToString()
        {

            return $"This is {this.name}";



        }
        public static void Main(string[] args)
        {
            MainClass mn = new MainClass();
            mn.set_x(10);


            Console.WriteLine(mn);





            Console.WriteLine("Value of x in the base class is : " + mn.x);
        }




    }
}
using System;


namespace Demo
{

    class AutoImplemented
    {


        public string Name { get; set; }// shortcut when no specific logic is required in getter and setter



        public AutoImplemented(string name)
        {
            this.Name = name;
        }







    }

    class MainApplication
    {



        public static void Main(string[] args)
        {
            Console.WriteLine("Creating an object of AutoImplemented Class");
            AutoImplemented autoImplemented = new AutoImplemented("Lokesh");


            Console.WriteLine(autoImplemented.Name);
            autoImplemented.Name = "Sid";

            Console.WriteLine(autoImplemented.Name);
        }
    }




}
using System;
namespace Demp
{


    interface IDog
    {

        void bark();

    }
    interface ICat
    {

        void muu();


    }


    class Dog : IDog
    {
        public void bark() { Console.WriteLine("Dog Barking"); }
    }

    class Cat : ICat
    {
        public void muu() { Console.WriteLine("Cat Muuing"); }

    }

    class Commom : ICat, IDog
    {
        public void bark()
        {

            Console.WriteLine("Commom bark");
        }

        public void muu() { Console.WriteLine("Common Muu"); }

    }

    class MainClass
    {
        public static void Main(string[] args)
        {


            Dog d = new Dog();
            Cat c = new Cat();
            Commom cm = new Commom();



            d.bark();
            c.muu();
            cm.bark();
            cm.muu();





        }
    }




}
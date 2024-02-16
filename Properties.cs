using System;
namespace Demo
{



    public class GetterAndSetter
    {


        private string firstName;

        public GetterAndSetter(string firstName)
        {

            FirstName = firstName;


        }



        public string FirstName
        {


            get
            {
                return firstName;
            }

            set
            {

                firstName = value;

            }
        }



    }


    class MainClass
    {
        public static void Main(string[] args)
        {
            var person1 = new GetterAndSetter("John");
            Console.WriteLine($"Person's name is {person1.FirstName}.");


            person1.FirstName = "Lokesh";

            Console.WriteLine($"Person's name is {person1.FirstName}.");

        }



    }



}
using System;

namespace Demo
{

    // Special class that contains a set of named integers .
    // Collections of constants that cannot be changed



    enum Planets
    {


        //      By defualt start from zero
        mercury = 1,
        venus = 2,
        earth = 3,
        mars = 4,
        jupiter = 5,
        neptune = 6,
        pluto = 7




    }




    class Enum
    {


        public static int calculate_sum(Planets p1, Planets p2)
        {



            return (int)p1 + (int)p2;
        }

        public static void Main(string[] args)
        {


            // Console.WriteLine(Planets.earth);

            // Console.WriteLine((int)Planets.earth);

            Console.WriteLine(calculate_sum(Planets.earth, Planets.mars));




        }





    }




}
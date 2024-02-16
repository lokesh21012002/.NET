using System;
using System.Threading;


namespace ThreadNamespace
{


    class Demo
    {


        public static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;

            mainThread.Name = "Main class thread";

            int time = 10;


            Thread downThread = new Thread((time) => CountDown(time));
            Thread upThread = new Thread((time) => CountUp(time));



            downThread.Start();
            upThread.Start();



            // Console.WriteLine(mainThread.Name);

            // CountDown(5);
            // CountUp(5);
            Console.WriteLine(mainThread.Name);






        }


        public static void CountDown(int end)
        {

            Console.WriteLine("Count down started");

            for (int i = 0; i < end; i++)
            {
                Console.WriteLine(i);

                Thread.Sleep(1000);
            }

            Console.WriteLine("Down time completed  ");
        }
        public static void CountUp(int start)
        {

            Console.WriteLine("Count up started");

            for (int i = start; i >= 0; i--)
            {
                Console.WriteLine(i);

                Thread.Sleep(1000);
            }

            Console.WriteLine("Up time completed  ");
        }
    }
}
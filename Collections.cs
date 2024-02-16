using System;
using System.Collections.Generic;


namespace Demo
{


    class CustomObj
    {
        string firstName, lastName;


        public CustomObj(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public override string ToString()
        {
            return $"{firstName} {lastName}";
        }





    }



    class CollectionClass
    {
        public static void Main(string[] args)
        {
            // List<String> list = new List<String>();
            // list.Add("Lokesh");
            // list.Add("Sid");
            // list.Add("Ayush");
            // list.Remove("Lokesh");
            // list.Insert(0, "Lokesh");

            // int sz = list.Count;


            // int idx = list.IndexOf("Lokesh1");
            // int idxlast = list.LastIndexOf("Lokesh");
            // string ans = (idx == -1) ? "not exits" : "exists";

            // Console.WriteLine(ans);
            // Console.WriteLine(list.Contains("Loki"));
            // list.Sort();






            // foreach (String i in list)
            // {
            //     Console.WriteLine(i);
            // }

            List<CustomObj> customlist = new List<CustomObj>();

            customlist.Add(new CustomObj("Lokesh", "Gawande"));
            customlist.Add(new CustomObj("Sid", "Chowdhury"));
            foreach (CustomObj obj in customlist)
            {



                Console.WriteLine(obj);
            }
        }
    }
}

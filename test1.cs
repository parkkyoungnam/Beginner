
using System;
using test;

namespace test1
{
    class Program_build
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Program pro = new Program();

            pro.age_bulid = 30;
            pro.name_bulid = "pkn";

            Console.WriteLine(pro.ToString());
            

        }
    }
}

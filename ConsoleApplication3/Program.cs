using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        public static void Drawstar(int s) {
            for(int i = 0; i < s; i++)
            {
                Console.Write("*");
            }
        }
        static void Main(string[] args)
        {


            string a, b, c;
            a = "hello";

            b = " my love";
            c = a + b;
            c = c.Substring(4, 6);
            Console.WriteLine(c);
            Drawstar(66);
            Console.ReadKey();



        }
    }
}
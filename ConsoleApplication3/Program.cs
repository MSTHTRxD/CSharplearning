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

            //this is my first program in c#
            float flMin = float.MinValue;
            float flMax = float.MaxValue;
            Console.WriteLine("Min Value = {0} Max Val = {1}", flMin,flMax);
            float flVar = 1f / 3;
            double dlVar = 1d / 3;
            decimal dcVar = 1m / 3;
            Console.WriteLine("float value= {0} \n double = {1} \n decimal = {2}", flVar, dlVar, dcVar);

            Console.ReadKey();


        }
    }
}
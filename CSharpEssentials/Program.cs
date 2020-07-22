using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEssentials
{
    class Program
    {
        static void Main(string[] args)
        {
            int @double;

            int i = 2322;
            double d = 23234.223;

            float f = 232432.34F;
            decimal m = 23423.2342M;

            long l = 3254353453L;

            int num1 = 2423;
            var num2 = 3234;//implicitly defines a datatype. But you have to declare and initialize in the same line.

            Console.WriteLine("Hello \n World");
            Console.WriteLine(@"Hello \n World");//prints hello and world in same line
            Console.WriteLine(@"Hello ""x"" World");//prints " 

            int cats = 20, dogs = 40;
            Console.WriteLine("There are "+cats + " cats and "+ dogs+" dogs");
            Console.WriteLine($"There are {cats} cats and {dogs} dogs"); //string interpolation

            Circle c1, c2;
            c1 = new Circle();
            c1.radius = 30;

            c2 = c1;

            Console.WriteLine(c1.radius);
            Console.WriteLine(c2.radius);

            c2.radius = 50;

            Console.WriteLine(c1.radius);

            string s1 = "a string";
            String s2 = s1;
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            s1 = "another string";
            Console.WriteLine(s1);
            Console.WriteLine(s2);

            double money = 324334.23;
            Console.WriteLine(money.ToString("C"));

            double perc = 0.05;
            Console.WriteLine(perc.ToString("P0"));

            int? num = null;//adding question mark to a datatype will help to accept the datatype  null value. We cannot add ? to string because it already can assign null values.
        }
    }

    class Circle
    {
        public int radius;

    }
}

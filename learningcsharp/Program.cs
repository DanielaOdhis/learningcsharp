using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learningcsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //wrting an output
            Console.WriteLine("Hello Friends!");
            Console.WriteLine("Y'all I can code in c# now!");
            Console.WriteLine("");

            //using strings
            string name = "Daniela";
            Console.WriteLine("My name is " + name);
            Console.WriteLine($"The name {name} has {name.Length} letters");

            string age = "21";
            Console.WriteLine($"I am  {age} years old");
            Console.WriteLine("");

            //using characters
            char letter = 'A';
            Console.WriteLine($"The first letter of the alphabet is {letter}");
            Console.WriteLine("");

            //literals
            int a = 5;
            int b = 6;

            // Compare the values
            bool result = (a == b);

            // Output true or false
            Console.WriteLine($"is 5 equals to 6?....{result}");
            Console.WriteLine("");

            //integers
            int d = 4;
            int e = 3;
            int c = d + e;
            int f = c / (d + e) ;

            Console.WriteLine($"4+ 3 is {c}");
            Console.WriteLine($"4 + 3 divided by 7 is { f}");
            int min2 = int.MinValue;
            int max2 = int.MaxValue;
            Console.WriteLine($"The range of integers is {min2} to {max2}");

            double g = 4.0;
            double h = 3.0;
            double i = g / h;
            Console.WriteLine("Using double");
            Console.WriteLine($"4.0 divided by 3.0 is {i}");
            double min1 = double.MinValue;
            double max1 = double.MaxValue;
            Console.WriteLine($"The range of double is {min1} to {max1}");

            decimal j = 4.0M;
            decimal k = 3.0M;
            decimal l = j / k;
            Console.WriteLine("Using decimal");
            Console.WriteLine($"4.0 divided by 3.0 is {l}");
            decimal min = decimal.MinValue;
            decimal max = decimal.MaxValue;
            Console.WriteLine($"The range of decimal is {min} to {max}");

            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}

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

            //using strings
            string name = "Daniela";
            Console.WriteLine("My name is " + name);
            Console.WriteLine($"The name {name} has {name.Length} letters");

            string age = "21";
            Console.WriteLine($"I am  {age} years old");

            //using characters
            char letter = 'A';
            Console.WriteLine($"The first letter of the alphabet is {letter}");

            //literals
            int a = 5;
            int b = 6;

            // Compare the values
            bool result = (a == b);

            // Output true or false
            Console.WriteLine(result);

            //integers
            int d = 4;
            int e = 3;
            int c = d + e;
            Console.WriteLine(c);


            Console.ReadKey();
        }
    }
}

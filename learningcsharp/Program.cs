﻿using System;
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
            Console.WriteLine("Hello Friends!");
            Console.WriteLine("Y'all I can code in c# now!");

            string name = "Daniela";
            Console.WriteLine("My name is " + name);
            Console.WriteLine($"The name {name} has {name.Length} letters");

            string age = "21";
            Console.WriteLine($"I am  {age} years old");

            int a = 4;
            int b = 3;
            int c = a + b;
            Console.WriteLine(c);


            Console.ReadKey();
        }
    }
}

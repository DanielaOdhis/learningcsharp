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

            //if statements
            int age1 = 21;
            if (age1 >= 18)
            {
                Console.WriteLine("You are an adult");
            }
            else
            {
                Console.WriteLine("You are a minor");
            }

            int m = 5;
            int n = 3;
            int o = 4;
            if((m+n+o>10) && (m == n))
            {
                Console.WriteLine("The answer is greater than 10");
                Console.WriteLine("And the first number is equal to the second");
            }
            else
            {
                Console.WriteLine("The answer is not greater than 10");
                Console.WriteLine("Or the first number is not equal to the second");
            }
            Console.WriteLine("");

            //Loops
            int counter = 0;
            while (counter < 10)
            {
                Console.WriteLine($"The counter is {counter}");
                counter++;
            }

            int counter1 = 10;
            do
            {
                Console.WriteLine($"The counter is {counter1}");
                counter1--;
            } while (counter1 > 0);

            for (int counter2 = 0; counter2 < 10; counter2++)
            {
                Console.WriteLine($"The counter is {counter2}");
            }
            Console.WriteLine("");

            //Combining branches and loops
            int sum = 0;
            for (int z=1; z <= 20;z++)
            {
                if (z % 3 == 0)
                {
                    sum = sum + z;
                }
            }
            Console.WriteLine($"The sum is {sum}");
            Console.ReadKey();
        }
    }
}

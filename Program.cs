using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {



            var age = 0;
            var weight = 0.0;
            var adult = false;
            var EXIT_CHAR = 'q';
            decimal BMI = 0.0m;
            var name = "";

            Console.WriteLine("Please enter your name ");
            name = Console.ReadLine();

            Console.WriteLine("Please enter your age");
            age = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Welcome {name} to BMI survey");
            Console.WriteLine("Are you above 18? reply true or false ");
            adult = bool.Parse(Console.ReadLine());

            while (adult == true)
            {








            }


            Console.ReadLine();



        }
    }
}

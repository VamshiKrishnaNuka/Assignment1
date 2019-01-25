using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            var age = 0;
            var dif = 0;
            var height = 0;
            var weight = 0.0;
            var adult = false;
            var EXIT_CHAR = 'q';
            decimal BMI = 0.0m;
            var name = "";

            Console.WriteLine("Please enter your name ");
            name = Console.ReadLine();

            Console.WriteLine("Please enter your age");
            age = Int32.Parse(Console.ReadLine());
            
            if (age >= 18)
            {
                Console.WriteLine($"Welcome {name} to BMI Calculator");
                Console.WriteLine("Please enter your weight in Kgs");
                weight = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Please enter your height");
                height = Int32.Parse(Console.ReadLine());
            }
            else
            {
                dif = 18 - age;
                Console.WriteLine($"{name} please try again after {dif} years ");
            }

            Console.ReadLine();



        }
    }
}

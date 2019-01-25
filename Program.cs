using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {

            var age = 0;
            var dif = 0;
            var height = 0.0;
            var weight = 0.0;
            var bmi = 0.0;
            var healthy = false;
            var EXIT_CHAR = 'q';
            decimal BMI = 0.0m;
            var name = "";

            Console.WriteLine("Welcome to BMI Calculator");
            Console.WriteLine("Please enter your name ");
            name = Console.ReadLine();

            Console.WriteLine("Please enter your age");
            age = Int32.Parse(Console.ReadLine());
            
            if (age >= 18)
            {
                Console.WriteLine($"{name} please provide the following details for BMI Calculation.");
                Console.WriteLine("Please enter your weight in Kgs");
                weight = Double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter your height in Meters");
                height = Double.Parse(Console.ReadLine());
                
            }
            else
            {
                dif = 18 - age;
                Console.WriteLine($"{name} please try again after {dif} years ");
            }
            while (weight==0.0 || height==0)
            {
                Console.WriteLine("Please try again");
            }

            bmi = weight / (height * height);
            BMI= (decimal)(bmi);
            Console.WriteLine($"{name} your calculated BMI is {BMI}");

            switch(bmi)
                {
                case var expression when bmi<18.5:
                    Console.WriteLine("Thin");
                    break;
                    
                case var expression when (bmi>=18.5 && bmi<25):
                    Console.WriteLine("Healthy");
                    break;
               
                case var expression when (bmi>=25 && bmi<29.9):
                    Console.WriteLine("Over Weight");
                    break;

                case var expression when bmi>30:
                    Console.WriteLine("Obese");
                    break;

                }

        }
    }
}

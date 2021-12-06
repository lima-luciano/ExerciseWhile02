using System;
using System.Globalization;

namespace ExerciseWhile02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Records the number of times items were selected
            int alc = 0, gas = 0, die = 0, choice;

            Console.WriteLine("1. Alcohol");
            Console.WriteLine("2. Gasoline");
            Console.WriteLine("3. Diesel");
            Console.WriteLine("4. End");

            choice = int.Parse(Console.ReadLine());
            while (choice != 4)
            {
                if (choice == 1)
                {
                    alc = alc + 1;
                }
                else if (choice == 2)
                {
                    gas = gas + 1;
                }
                else if (choice == 3)
                {
                    die = die + 1;
                }
                else
                {
                    Console.WriteLine("Invalid. Please enter another option");
                }
                choice = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("THANK YOU VERY MUCH!");
            Console.WriteLine("Alcohol:" + alc);
            Console.WriteLine("Gasoline:" + gas);
            Console.WriteLine("Diesel:" + die);

        }
    }
}
//Solved exercise by lima-luciano on 11/16/2021

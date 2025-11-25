
using CalculatorApp;
namespace CSharpExercises

{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.Clear();
            Console.WriteLine("Hello, World!");

            Console.WriteLine("---CSharp Exercises---");
            Console.WriteLine("Chose a topic.");
            Console.WriteLine("1. nope");
            Console.WriteLine("2. OOP Week 03-10");
            Console.WriteLine("3. nope");
            Console.WriteLine("Quit. Exit the program.");

            string choice = Console.ReadLine();

            switch (choice)
            {



                case "2":
                    OOPExerciseSelector();
                    break;

                case "Quit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid input, please try again.");
                    Main(args);
                    break;
            }

            static void OOPExerciseSelector()
            {
                Console.Clear();
                Console.WriteLine("OOP Exercises - Choose an exercise:");
                Console.WriteLine("1. Calculator");
                Console.WriteLine("2. Exercise 2");
                Console.WriteLine("3. Back to Main Menu");

                string oopChoice = Console.ReadLine();

                switch (oopChoice)
                {
                    //case 1 is to calculator, calc.cs

                    case "1":
                        Calculator.Run();
                        break;


                    case "3":
                        Main(new string[] { });
                        break;
                    default:
                        Console.WriteLine("Invalid input, please try again.");
                        OOPExerciseSelector();
                        break;
                }




            }
        }
    }
}
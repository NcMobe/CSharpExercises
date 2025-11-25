
namespace CalculatorApp

{
    class Calculator
    {

        public static void Run()
        {

            Console.WriteLine("Enter two numbers.");
            Console.WriteLine("nr1: ");

            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose an operation:");
            Console.WriteLine("+-*/ : ");
            var operation = Console.ReadLine();

            Console.WriteLine("nr2: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            double total = 0;

            switch (operation)
            {
                case "+":
                    total = number1 + number2;
                    break;

                case "-":
                    total = number1 - number2;
                    break;

                case "*":
                    total = number1 * number2;
                    break;

                case "/":

                    if (number2 != 0)
                        total = number1 / number2;

                    else

                        Console.WriteLine("ERR");
                    return;

                default:
                    Console.WriteLine("ERR");
                    return;

            }
            Console.WriteLine($"Total: {total}");

            Console.WriteLine("Press any key to return to the menu.");
            Console.ReadKey();
            Console.Clear();
            CSharpExercises.Program.Main(new string[] { });

        }
    }
}
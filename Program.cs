using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //Initializing unchanging variables
            var numOfCupsOfCoffee = 0;
            var fullName = "Jerid Fenderson";
            var today = DateTime.Now;

            //Displaying unchanging variables
            Console.WriteLine($"Hi {fullName}, I see you've had {numOfCupsOfCoffee} cups of coffee today, {today}.");

            //Asking and capturing user's name and displaying 1 of 2 messages based on that
            Console.Write("What is your name? ");
            var userName = Console.ReadLine();
            if (userName == "Alice")
            {
                Console.WriteLine($"Welcome to Wonderland, {userName}");
                Console.WriteLine("You're in the rabbit hole now. Goodbye");
                Environment.Exit(-1);
            }
            else
            {
                Console.WriteLine($"Welcome to the Matrix, {userName}");
            }

            //Asking and capturing random numbers
            Console.Write($"{userName}, give me a random number: ");
            var firstOperand = double.Parse(Console.ReadLine());
            Console.Write("Give me another random number: ");
            var secondOperand = double.Parse(Console.ReadLine());

            //Quick Maths
            var sum = firstOperand + secondOperand;
            var difference = firstOperand - secondOperand;
            var product = firstOperand * secondOperand;
            var quotient = firstOperand / secondOperand;
            var remainder = firstOperand % secondOperand;

            //Displaying Quick Maths
            Console.WriteLine($"The sum of your numbers is {sum}");
            Console.WriteLine($"The difference of your numbers is {difference}");
            Console.WriteLine($"The product of your numbers is {product}");
            Console.WriteLine($"The quotient of your numbers is {quotient}");
            Console.WriteLine($"The remainder of your numbers is {remainder}");

        }
    }
}

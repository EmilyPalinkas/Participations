using System;

namespace _P__Functions___Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            const string developerName = "Emily Palinkas";
            const string className = "intro to programming";
            const string date = "April 7, 2021";

            DeveloperName(developerName, className, date);

            double calculation = 0;
            char whatNext;

            do
            {
                Console.WriteLine("What type of calculation do you want to perform? Add, subtract, multiply or divide. >>");
                string answer = Console.ReadLine().ToLower();

                while ((answer != "add") && (answer != "subtract") && (answer != "multiply") && (answer != "divide"))
                {
                    Console.WriteLine("incorrect response, try again");
                    answer = Console.ReadLine().ToLower();
                }

                Console.WriteLine("Enter first number >>");
                double number1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter second number >>");
                double number2 = Convert.ToDouble(Console.ReadLine());

                if (answer == "add")
                {
                    calculation = Add(number1, number2);
                    Console.WriteLine($"{number1.ToString("N")} + {number2.ToString("N")} = {calculation.ToString("N")}");
                }
                else if (answer == "subtract")
                {
                    calculation = Subtract(number1, number2);
                    Console.WriteLine($"{number1.ToString("N")} - {number2.ToString("N")} = {calculation.ToString("N")}");
                }
                else if (answer == "multiply")
                {
                    calculation = Multiply(number1, number2);
                    Console.WriteLine($"{number1.ToString("N")} * {number2.ToString("N")} = {calculation.ToString("N")}");
                }
                else if (answer == "divide")
                {
                    calculation = Divide(number1, number2);
                    Console.WriteLine($"{number1.ToString("N")} / {number2.ToString("N")} = {calculation.ToString("N")}");
                }

                // new calc

                Console.WriteLine($"A: would you like to perform a new calculation, B: use {calculation.ToString("N")} in a new calculation.");
                whatNext = Convert.ToChar(Console.ReadLine().ToUpper());
              
                while (whatNext == 'B')
                {
                    Console.WriteLine("what type of calculation do you want to perform? add, subtract, multiply, divide >>");
                    answer = Console.ReadLine().ToLower();

                    while ((answer != "add") && (answer != "subtract") && (answer != "multiply") && (answer != "divide"))
                    {
                        Console.WriteLine("Incorrect response, try again >>");
                        answer = Console.ReadLine().ToLower();
                    }

                    number1 = calculation;

                    Console.WriteLine("Enter a second number >>");
                    number2 = Convert.ToDouble(Console.ReadLine());

                    if (answer == "add") 
                    {
                        calculation = Add(number1, number2);
                        Console.WriteLine($"{number1.ToString("N")} + {number2.ToString("N")} = {calculation.ToString("N")}");
                    }
                    else if (answer == "subtract")
                    {
                        calculation = Subtract(number1, number2);
                        Console.WriteLine($"{number1.ToString("N")} - {number2.ToString("N")} = {calculation.ToString("N")}");
                    }
                    else if (answer == "multiply")
                    {
                        calculation = Multiply(number1, number2);
                        Console.WriteLine($"{number1.ToString("N")} * {number2.ToString("N")} = {calculation.ToString("N")}");
                    }
                    else if (answer == "divide")
                    {
                        calculation = Divide(number1, number2);
                        Console.WriteLine($"{number1.ToString("N")} / {number2.ToString("N")} = {calculation.ToString("N")}");
                    }
                    Console.WriteLine($"A:would you like to perform a new calculation, B: use {calculation.ToString("N")} in a new calculation");
                    whatNext = Convert.ToChar(Console.ReadLine().ToUpper());
                }
                if (whatNext == 'C')
                {
                    Console.WriteLine("Thanks, bye");
                }


            } while (whatNext == 'A');

        }

        static double Add(double number1, double number2)
        {
            double number3 = 0;
            number3 = number1 + number2;
            return number3;
        }

        static double Subtract(double number1, double number2)
        {
            double number3 = 0;
            number3 = number1 - number2;
            return number3;
        }

        static double Multiply(double number1, double number2)
        {
            double number3 = 0;
            number3 = number1 * number2;
            return number3;
        }

        static double Divide(double number1, double number2)
        {
            double number3 = 0;
            number3 = number1 / number2;
            return number3;
        }

        static void DeveloperName(string developerName, string className, string date)
        {
            Console.WriteLine($"{developerName} wrote this for the class {className} on {date}.");
            Console.WriteLine();
            return;
        }
    }
}

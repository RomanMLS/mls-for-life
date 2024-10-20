

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Simple Calculator");
                Console.WriteLine("-----------------");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.Write("Select an operation (1-5): ");

                int choice;
                if (int.TryParse(Console.ReadLine(), out choice) && choice >= 1 && choice <= 5)
                {
                    if (choice == 5)
                    {
                        Console.WriteLine("Exiting the program...");
                        break;
                    }

                    Console.Write("Enter the first number: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Enter the second number: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    double result = 0;

                    switch (choice)
                    {
                        case 1:
                            result = num1 + num2;
                            Console.WriteLine($"Result of Addition: {num1} + {num2} = {result}");
                            break;
                        case 2:
                            result = num1 - num2;
                            Console.WriteLine($"Result of Subtraction: {num1} - {num2} = {result}");
                            break;
                        case 3:
                            result = num1 * num2;
                            Console.WriteLine($"Result of Multiplication: {num1} * {num2} = {result}");
                            break;
                        case 4:
                            if (num2 != 0)
                            {
                                result = num1 / num2;
                                Console.WriteLine($"Result of Division: {num1} / {num2} = {result}");
                            }
                            else
                            {
                                Console.WriteLine("Error: Cannot divide by zero.");
                            }
                            break;
                    }

                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
                    Console.ReadKey();
                }
            }
        }
    }
}
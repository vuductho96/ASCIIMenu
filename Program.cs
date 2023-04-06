using System;

namespace MenuDrawing
{
    class MenuDrawingView
    {


        static void Main(string[] args)
        {
            int choice;


            do
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1. Print the rectangle");
                Console.WriteLine("2. Print the square triangle");
                Console.WriteLine("3. Print isosceles triangle");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:


                        Console.WriteLine("Drawing the square triangle:");
                        for (int i = 1; i <= 5; i++)
                        {
                            for (int j = 1; j <= 7; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }


                        break;
                    case 2:
                        Console.WriteLine("Drawing the square triangle:");
                        for (int i = 1; i <= 5; i++)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 3:
                        for (int i = 1; i <= 7; i += 2)
                        {
                            for (int j = 7; j >= i; j -= 2)
                            {
                                Console.Write(" ");
                            }
                            for (int k = 1; k <= i; k++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;
                    case 0:
                        Console.WriteLine("Exiting program. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }

                Console.WriteLine();
            } while (choice != 0);
        }
    }
}

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
                Console.WriteLine("1. Draw the triangle");
                Console.WriteLine("2. Draw the square");
                Console.WriteLine("3. Draw the rectangle");
                Console.WriteLine("0. Exit");
                Console.Write("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Drawing the triangle:");
                        Console.WriteLine("******\n*****\n****\n***\n**\n*");
                        break;
                    case 2:
                        Console.WriteLine("Drawing the square:");
                        Console.WriteLine("* * * * * *\n* * * * * *\n* * * * * *\n* * * * * *\n* * * * * *\n* * * * * *");
                        break;
                    case 3:
                        Console.WriteLine("Drawing the rectangle:");
                        Console.WriteLine("* * * * * *\n* * * * * *\n* * * * * *");
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

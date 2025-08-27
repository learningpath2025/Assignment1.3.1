//Write a program in C# to calculate area of triangle, square and rectangle. Write 3 different functions for each shape to take dimensions of figure and display the area. You may create menus.


namespace Assignment1._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {

                bool continueProgram = true;
                string? choice;

                while (continueProgram)
                {
                    choice = MenuChoice();

                    if (choice == "4")
                    {
                        continueProgram = false;
                        Console.WriteLine("Exiting the program.");
                        break;
                    }

                    switch (choice)
                    {
                        case "1":
                            double triangleArea = AreaOfTriangle();
                            if (triangleArea == -1)
                            {
                                Console.WriteLine("Invalid input for triangle dimensions. Please enter positive values.");
                                break;
                            }
                            Console.WriteLine($"Area of the triangle is: {triangleArea}");
                            break;
                        case "2":
                            double squareArea = AreaOfSquare();
                            if (squareArea == -1)
                            {
                                Console.WriteLine("Invalid input for square dimensions. Please enter positive values.");
                                break;
                            }
                            Console.WriteLine($"Area of the square is: {squareArea}");
                            break;
                        case "3":
                            double rectangleArea = AreaOfRectangle();
                            if (rectangleArea == -1)
                            {
                                Console.WriteLine("Invalid input for rectangle dimensions. Please enter positive values.");
                                break;
                            }
                            Console.WriteLine($"Area of the rectangle is: {rectangleArea}");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please select a valid operation.");
                            break;
                    }

                    Console.WriteLine("Do you want to perform another operation? (y/n)");
                    string? continueChoice = Console.ReadLine();
                    string? LowerContinueChoice = continueChoice?.ToLower();

                    if (continueChoice != null)
                    {
                        switch (LowerContinueChoice)
                        {
                            case "y":
                                continueProgram = true;
                                break;
                            case "n":
                                continueProgram = false;
                                Console.WriteLine("Exiting the program.");
                                break;
                            default:
                                Console.WriteLine("Invalid input. Exiting the program.");
                                continueProgram = false;
                                break;
                        }
                    }
                    else if (continueChoice == null)
                    {
                        Console.WriteLine("Null value is considered invalid input. Exiting the program.");
                        continueProgram = false;

                    }
                }
            }
            catch (Exception e)
            {

                Console.WriteLine($"Exception: {e}");
            }
        }

        static string MenuChoice()
        {
            Console.WriteLine("Select an operation:");
            Console.WriteLine("1. Triangle");
            Console.WriteLine("2. Square");
            Console.WriteLine("3. Rectangle");
            Console.WriteLine("4. Exit");

            string? choice = Console.ReadLine();
            if (choice == null)
            {
                choice = "Invalid";
            }
            return choice;
        }

        static bool IsPositive(double number)
        {
            return number > 0;
        }

        static double AreaOfTriangle()
        {
            Console.WriteLine("Enter base length of the triangle:");
            double triangleBase = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter height of the triangle:");
            double triangleHeight = Convert.ToDouble(Console.ReadLine());

            if (!IsPositive(triangleBase) || !IsPositive(triangleHeight))
            {
                return -1;
            }
            return 0.5 * triangleBase * triangleHeight;
        }

        static double AreaOfSquare()
        {
            Console.WriteLine("Enter side length of the square:");
            double squareSide = Convert.ToDouble(Console.ReadLine());

            if (!IsPositive(squareSide))
            {
               return -1; 
            }
            return squareSide * squareSide;
        }

        static double AreaOfRectangle()
        {
            Console.WriteLine("Enter length of the rectangle:");
            double rectangleLength = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter breadth of the rectangle:");
            double rectangleBredth = Convert.ToDouble(Console.ReadLine());

            if (!IsPositive(rectangleLength) || !IsPositive(rectangleBredth))
            {
                return -1;
            }
            return rectangleLength * rectangleBredth;
        }

    }
}

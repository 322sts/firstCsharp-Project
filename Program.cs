using System;
using System.Net.NetworkInformation;
class AreaShapeCalculator
{
  static void Main()
    {
        string again = "y";
        
    while (again == "y")
        {
            Console.WriteLine("==================");
            Console.WriteLine("Area Calculator 📐");
            Console.WriteLine("==================");
            Console.WriteLine("\nChoose a shape to calculate the area (Enter the number):");
            Console.WriteLine("\n1) Triangle : 1");
            Console.WriteLine("2) Rectangle : 2");
            Console.WriteLine("3) Square : 3");
            Console.WriteLine("4) Circle : 4");
            Console.WriteLine("5) Quit : 5");
            Console.WriteLine("");
            string choiceString = Console.ReadLine();
            int choice = int.Parse(choiceString);
            
            if (choice == 1)
            {
                Console.WriteLine("You choose Triangle");
                
                Console.WriteLine("Enter the Base of the triangle:");
                string baseLengthString = Console.ReadLine();
                double baseLength = double.Parse(baseLengthString);
                
                Console.WriteLine("Enter the Height of the triangle:");
                string baseHeightString = Console.ReadLine();
                double baseHeight = double.Parse(baseHeightString);
                
                Console.WriteLine("\nBase: " + baseLength);
                Console.WriteLine("Height: " + baseHeight);

                double area = baseLength * baseHeight / 2;
                Console.WriteLine("\nThe area of this triangle is " + area);
            }

            else if (choice == 2)
            {
                Console.WriteLine("You choose Rectangle");
                
                Console.WriteLine("Enter the Base of the Rectangle:");
                string baseLengthString = Console.ReadLine();
                double baseLength = double.Parse(baseLengthString);
                
                Console.WriteLine("Enter the Height of the Rectangle:");
                string baseHeightString = Console.ReadLine();
                double baseHeight = double.Parse(baseHeightString);
                
                Console.WriteLine("\nBase: " + baseLength);
                Console.WriteLine("Height: " + baseHeight);

                double area = baseLength * baseHeight;
                Console.WriteLine("\nThe area of this rectangle is " + area);
            }
            
            else if (choice == 3)
            {
                Console.WriteLine("You choose Square");
                
                Console.WriteLine("Enter the Side of the Square:");
                string sideLengthString = Console.ReadLine();
                double sideLength = double.Parse(sideLengthString);
                
                Console.WriteLine("\nSide: " + sideLength);

                double area = sideLength * sideLength;
                Console.WriteLine("\nThe area of this Square is " + area);
            }
            
            else if (choice == 4)
            {
                Console.WriteLine("You choose Circle");
                
                Console.WriteLine("Enter the Radius of the Circle:");
                string radiusLengthString = Console.ReadLine();
                double radiusLength = double.Parse(radiusLengthString);
                
                Console.WriteLine("\nBase: " + radiusLength);

                double area = Math.PI * radiusLength * radiusLength;
                Console.WriteLine("\nThe area of this Circle is " + area);
            }

            else if (choice == 5)
            {
                Console.WriteLine("You choose to quit");
            }
            Console.WriteLine("Do you want to calculate again (y/n)");
            again = Console.ReadLine();
        }
    }  
}


/*
Create a program that calculates the area of one shape. 🟦

Choose one of the following shapes:

Square
Rectangle
Triangle
Circle
Your program should ask the user for the measurements needed for your chosen shape, calculate the area, and print the result.

Here are the area equations for each shape:

Shape	Equation
Square	area=side 
2
 
Rectangle	area=length∗width
Triangle	area=(height∗base)/2
Circle	area=π∗radius 
2
 
For pi π in the area of a circle, feel free to use 3.14.

Your program should:

Ask the user for measurements
Store values in variables
Use math to calculate the area
Print the area to the console
After calculating the area, ask the user if they'd like to calculate another shape and use a loop to run the program again.
The output should look something like this:

==================
Area Calculator 📐
==================

1) Triangle
2) Rectangle
3) Square
4) Circle
5) Quit

Which shape: 1

Base: 5
Height: 6

The area is 15

Calculate again? (y/n)

Choose whichever shape you'd like and build your own area calculator!
*/

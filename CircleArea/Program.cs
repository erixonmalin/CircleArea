using System;

namespace CircleArea
{
    internal class Program // This program prints the area of two circles with the radius of 5 and 6. 
    {    
        static void Main(string[] args)
        {
            Circle circle1 = new Circle(5); // new object from the class Circle assigned value 5. 
            Circle circle2 = new Circle(6); // new object assigned value 6.
            {
                Console.WriteLine($"Area is {circle1.GetArea()}"); // retrieves method and using string literal
            }
            {
                Console.WriteLine($"Area is {circle2.GetArea()}");
            }                                                      
        }
    }
}

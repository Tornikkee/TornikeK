using System;

namespace GeometricShapes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1.Circle ");
            Console.Write("2.Rectangle ");
            Console.Write("3.Triangle ");
            Console.Write("\n");
            Console.Write("Choose shape(write 1 for circle, 2 for rectangle, 3 for triangle): ");

            int userChoice = 0;
            try
            {
                userChoice = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            if(userChoice <= 3 && userChoice >= 1)
            {
                switch (userChoice)
                {
                    case 1:
                        
                        Console.Write("Enter circle radius: ");
                        double radius = 0;

                        try
                        {
                            radius = Convert.ToDouble(Console.ReadLine());
                            Circle circle = new Circle(radius);
                            Console.WriteLine("Circle length = {0}", circle.Perimeter());
                            Console.WriteLine("Circle area = {0}", circle.Area());
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        
                        break;

                    case 2:

                        double recSide1 = 0;
                        double recSide2 = 0;

                        try
                        {
                            Console.Write("Enter rectangle side 1: ");
                            recSide1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter rectangle side 2: ");
                            recSide2 = Convert.ToDouble(Console.ReadLine());
                            Rectangle rectangle = new Rectangle(recSide1, recSide2);
                            Console.WriteLine($"Rectagnle perimeter = {rectangle.Perimeter()}");
                            Console.WriteLine($"Rectangle area = {rectangle.Area()}");
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        
                        break;

                    case 3:

                        double side1 = 0;
                        double side2 = 0;
                        double side3 = 0;

                        try
                        {
                            Console.Write("Enter triangle side 1: ");
                            side1 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter triangle side 2: ");
                            side2 = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Enter triangle side 3: ");
                            side3 = Convert.ToDouble(Console.ReadLine());
                            try
                            {
                                var triangle = new Triangle(side1, side2, side3);
                                Console.WriteLine($"Triangle perimeter = {triangle.Perimeter()}");
                                Console.WriteLine($"Triangle area = {triangle.Area()}");
                            }
                            catch (InvalidTriangleException ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                            }
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        
                        break;
                }
            }
            else if (userChoice > 3 || userChoice < 1)
            {
                Console.WriteLine("Given input does not correspond any action...");
            }
        }
    }
}

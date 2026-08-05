using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square ("Red", 5);
        shapes.Add(s1);

        Rectangle r1 = new Rectangle("Blue", 5, 10);
        shapes.Add(r1);

        Circle c1 = new Circle("Green", 6);
        shapes.Add(c1);

        Square s2 = new Square ("Yellow", 10);
        shapes.Add(s2);

        Rectangle r2 = new Rectangle("Orange", 6.1234, 18.4567);
        shapes.Add(r2);

        Circle c2 = new Circle("Pink", 7.123456);
        shapes.Add(c2);


        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The shapes color is {color}, it has an area of {area}");
        }


    }

    


}
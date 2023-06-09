// See https://aka.ms/new-console-template for more information
//1.Accept radius of a circle. Display area of a circle.
Console.WriteLine("Enter readius of a circle");

double radius = Convert.ToDouble(Console.ReadLine());

double Area  = Math.PI * radius * radius;

Console.WriteLine("Area of Circle: " + Area);

Console.ReadLine();


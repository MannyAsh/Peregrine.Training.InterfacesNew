﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesNew
{
     class Program
    {
        static void Main(string[] args) {

            Rectangle rec = new Rectangle();
            Circle circle = new Circle();
            Triangle triangle = new Triangle();

            double a = 10;

            double b = 20;

            double c = 1.0;

            double area = 0.0;

            double perimeter = 0.0;

            rec.height = a;
            rec.width =b;
            area = rec.Area();
            Console.WriteLine("Area of rectangle is: {0:F}", area);

            Console.WriteLine("-----------------------------------");

            circle.radius = c;

            area = circle.Area();

            Console.WriteLine("Area of circle is: {0:F}", area);
            perimeter = circle.perimeter();
            Console.WriteLine("Perimeter of circle is: {0:F}", perimeter);

            triangle.bas = a;
            triangle.height = b;
            area = triangle.Area();
            triangle.Area();


            Console.WriteLine("Area of a triangle is: {0:F}", area);



            triangle.sideOne = a;
            triangle.sideTwo = b;   
            triangle.sideThree = c;
           
            perimeter = triangle.perimeter();
            Console.WriteLine("Perimeter of a triangle is: {0:F}", perimeter);
            
            Console.Read();





        }
    }
}

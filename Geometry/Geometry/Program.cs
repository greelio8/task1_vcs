using System;

namespace Geometry
{
     class Program
     {
          static void Main(string[] args) {
               Rectangle rect = new Rectangle(20, 1);
               Circle circle = new Circle(5);

               Console.WriteLine(rect.Area());
          }
     }
}

/// Kyle Byassee
/// 2023-02-03
/// 
/// This is an interface for the shape factory.
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace facPattern
{
    // The base interface has a draw method because every derived class overrides the method.
    interface IGeometricShape
    {
        public void draw();
    }
    // Line uses the IGeometricShape interface.
    class Line : IGeometricShape
    {
        public void draw()
        {
            Console.WriteLine("Line is drawn.");
        }
    }
    // Circle uses the IGeometricShape interface.
    class Circle : IGeometricShape
    {
        public void draw()
        {
            Console.WriteLine("Circle is drawn.");
        }
    }
    // Rectangle uses the IGeometricShape interface.
    class Rectangle : IGeometricShape
    {
        public void draw()
        {
            Console.WriteLine("Rectangle is drawn.");
        }
    }
    // Triangle uses the IGeometricShape interface.
    //class Triangle : IGeometricShape
    //{
        //public void draw()
        //{
            //Console.WriteLine("Triangle is drawn.");
        //}
    //}
}

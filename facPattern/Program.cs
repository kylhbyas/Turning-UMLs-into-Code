// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/// Kyle Byassee
/// 2023-02-03
/// 
/// This program loops over the different shape types and prints them.
/// 

namespace facPattern
{
    enum ShapeType
    {
        LINE,
        CIRCLE,
        RECTANGLE,
        TRIANGLE,
    }

    /*
     * 
     * 
     * Since private fields cannot be accessed by derived 
     *  classes the public helper fuctions were neccessary.
     *  
     */
    class ShapeFactory
    {
        public IGeometricShape getShape(ShapeType type)
        {
            IGeometricShape? L; // nullable

            if (type == ShapeType.LINE)
            {
                L = new Line();
            }
            else if (type == ShapeType.CIRCLE)
            {
                L = new Circle();
            }
            else if (type == ShapeType.RECTANGLE)
            {
                L = new Rectangle();
            }
            //else if (type == ShapeType.TRIANGLE)
            //{
                //L = new Triangle();
            //}
            else
            {
                L = null;
            }
            return L;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory factory = new ShapeFactory();

            foreach (ShapeType n in Enum.GetValues(typeof(ShapeType)))
            {
                IGeometricShape shape = factory.getShape(n);
                if (shape == null)
                {
                    Console.WriteLine("I didn't get the shape I asked for.");
                }
                else
                {
                    shape.draw();
                }
            }
            //Console.ReadKey();
        }
    }
}
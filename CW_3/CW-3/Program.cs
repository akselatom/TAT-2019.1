
namespace CW_3
{
    using System;

    /// <summary>
    /// Entry point class. Program build different triangles implementation of which is built on chain responsibility.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point method
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            try
            {
                Point a = new Point(0, 1);
                Point b = new Point(4, 1);
                Point c = new Point(4, 4);
                FigureBuilder triangleBuilder = new EquilateralBuilder(new RightBuilder(new UsualBuilder(null)));
                Triangle triangle = triangleBuilder.CreateTriangle(a, b, c);
                Console.WriteLine(triangle.GetTriangleType());
                Console.WriteLine("Area:{0}", triangle.GetArea());

            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}

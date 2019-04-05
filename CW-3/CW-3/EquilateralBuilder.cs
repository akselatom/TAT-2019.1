namespace CW_3
{
    using System;

    /// <inheritdoc/>
    /// <summary>
    /// Builder for equilateral triangle
    /// </summary>
    public class EquilateralBuilder : FigureBuilder
    {
        /// <inheritdoc/>
        public EquilateralBuilder(FigureBuilder builder)
        {
            this.Successor = builder;
        }

        /// <summary>
        /// Creates a new instance of <see cref="EquilateralTriangle"/>if the sides of the triangles satisfy the conditions
        /// </summary>
        /// <param name="a">triangle tops</param>
        /// <param name="b">triangle tops</param>
        /// <param name="c">triangle tops</param>
        /// <returns>
        /// instance of <see cref="EquilateralTriangle"/>
        /// </returns>
        public override Triangle CreateTriangle(Point a, Point b, Point c)
        {
            double epsilon = 0.0001;
            if (Math.Abs(a.GetDistanceBetween(b) - b.GetDistanceBetween(c)) < epsilon
                && Math.Abs(c.GetDistanceBetween(a) - a.GetDistanceBetween(b)) < epsilon)
            {
                return new EquilateralTriangle(a, b, c);
            }

            if (this.Successor != null)
            {
                return this.Successor.CreateTriangle(a, b, c);
            }

            throw new ArgumentException("all builders cannot build a triangle");
        }
    }
}
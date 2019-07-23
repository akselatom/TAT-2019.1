namespace CW_3
{
    using System;

    /// <inheritdoc/>
    /// <summary>
    /// The isosceles triangle.
    /// </summary>
    public class EquilateralTriangle : Triangle
    {
        /// <inheritdoc/>
        public EquilateralTriangle(Point a, Point b, Point c)
            : base(a, b, c)
        {
        }

        /// <inheritdoc/>
        public override double GetArea()
        {
            return Math.Sqrt(3.0) * this.AC / 4;
        }

        /// <inheritdoc/>
        public override string GetTriangleType()
        {
            return this.GetType().Name;
        }
    }
}
namespace CW_3
{
    using System;

    /// <inheritdoc/>
    public class UsualTriangle : Triangle
    {
        /// <inheritdoc/>
        public UsualTriangle(Point a, Point b, Point c)
            : base(a, b, c)
        {
        }

        /// <inheritdoc/>
        public override double GetArea()
        {
            var semiPerimeter = (this.AB + this.BC + this.AC) / 2.0;
            return Math.Sqrt(
                semiPerimeter * (semiPerimeter - this.AB) * (semiPerimeter - this.AC) * (semiPerimeter - this.BC));
        }

        /// <inheritdoc/>
        public override string GetTriangleType()
        {
            return this.GetType().Name;
        }
    }
}
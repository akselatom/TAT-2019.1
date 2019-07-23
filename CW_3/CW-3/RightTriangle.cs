namespace CW_3
{
    using System;

    /// <inheritdoc/>
    public class RightTriangle : Triangle
    {
        /// <inheritdoc/>
        public RightTriangle(Point a, Point b, Point c)
            : base(a, b, c)
        {
        }

        /// <inheritdoc/>
        public override double GetArea()
        {
            if (this.AC > this.BC && this.AC > this.AB)
            {
                return this.BC * this.AB / 2.0;
            }
            if (this.BC > this.AC && this.BC > this.AB)
            {
                return this.AC * this.AB / 2.0;
            }

            return this.AB * this.BC / 2.0;
        }

        /// <inheritdoc/>
        public override string GetTriangleType()
        {
            return this.GetType().Name;
        }
    }
}
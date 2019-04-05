namespace CW_3
{
    using System;

    /// <inheritdoc/>
    /// <summary>
    /// Builder for right triangle
    /// </summary>
    public class RightBuilder : FigureBuilder
    {
        /// <inheritdoc/>
        public RightBuilder(FigureBuilder builder)
        {
            this.Successor = builder;
        }

        /// <summary>
        /// Creates a new instance of <see cref="RightTriangle"/>if the sides of the triangles satisfy the conditions
        /// </summary>
        /// <param name="a">triangle tops</param>
        /// <param name="b">triangle tops</param>
        /// <param name="c">triangle tops</param>
        /// <returns>
        /// instance of <see cref="RightTriangle"/>
        /// </returns>
        public override Triangle CreateTriangle(Point a, Point b, Point c)
        {
            if ((a.X == b.X && b.Y == c.Y) || (a.Y == c.Y && b.X == c.X) || (a.Y == b.Y && b.X == c.X)) 
            {
                return new RightTriangle(a, b, c);
            }

            if (this.Successor != null)
            {
                return this.Successor.CreateTriangle(a, b, c);
            }

            throw new ArgumentException("all builders cannot build a triangle");
        }
    }
}
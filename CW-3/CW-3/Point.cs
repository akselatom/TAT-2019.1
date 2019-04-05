namespace CW_3
{
    using System;

    /// <summary>
    /// Class describing a point in two-dimensional space
    /// </summary>
    public struct Point
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> struct.
        /// </summary>
        /// <param name="x">
        /// The x.
        /// </param>
        /// <param name="y">
        /// The y.
        /// </param>
        public Point(int x, int y)
            : this()
        {
            this.X = x;
            this.Y = y;
        }
        public int X { get; set; }

        public int Y { get; set; }

        /// <summary>
        /// Get distance between points.
        /// </summary>
        /// <param name="anotherPoint">
        /// The another point.
        /// </param>
        /// <returns>
        /// Distance between points/
        /// </returns>
        public double GetDistanceBetween(Point anotherPoint)
        {
            return Math.Sqrt(Math.Pow(this.X - anotherPoint.X, 2) + Math.Pow(this.Y - anotherPoint.Y, 2));
        }
    }
}
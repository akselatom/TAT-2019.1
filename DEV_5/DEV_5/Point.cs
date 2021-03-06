﻿
namespace DEV_5
{
    using System;

    /// <summary>
    /// The point.
    /// </summary>
    public struct Point
    {
        /// <summary>
        /// The coordinates.
        /// </summary>
        private float[] coordinates;

        /// <summary>
        /// The number of dimensions.
        /// </summary>
        private int dimension;

        /// <summary>
        /// Initializes a new instance of the <see cref="Point"/> struct.
        /// </summary>
        /// <param name="coordinates">
        /// The coordinates.
        /// </param>
        /// <param name="dimension">
        /// The dimension.
        /// </param>
        /// <exception cref="ArgumentException">
        /// All program logic is built on work with the 3rd dimension
        /// </exception>
        public Point(float[] coordinates, int dimension = 3)
        {
            if (dimension != 3 && coordinates.Length != dimension)
            {
                throw new ArgumentException("This program works only with 3rd dimension.");
            }

            this.coordinates = coordinates;
            this.dimension = dimension;
        }

        /// <summary>
        /// Get distance between two points
        /// </summary>
        /// <param name="newPoint">
        /// The new <see cref="Point"/>.
        /// </param>
        /// <returns>
        /// Returns distance between two points.
        /// </returns>
        public double GetDistance(Point newPoint)
        {
            double distance = 0;
            for (int i = 0; i < this.dimension; i++)
            {
                distance += Math.Pow(newPoint.coordinates[i] - this.coordinates[i], 2);
            }

            return Math.Pow(distance, 0.5);
        }
    }
}

namespace DEV_5
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc />
    /// <summary>
    /// The plane.
    /// </summary>
    public class Plane : IFlyable
    {
        /// <summary>
        /// Plane current speed.
        /// </summary>
        private int speed;

        /// <summary>
        /// Initializes a new instance of the <see cref="Plane"/> class.
        /// </summary>
        public Plane()
        {
            this.RouteList = new List<Point> { new Point(new float[] { 0, 0, 0 }) };
            this.speed = 200;
        }

        /// <summary>
        /// Gets all <see cref="Point"/> in which there was a <see cref="Bird"/>
        /// </summary>
        public List<Point> RouteList { get; private set; }

        /// <inheritdoc />
        /// <summary>
        /// Adds a new point to <see cref="RouteList"/>
        /// </summary>
        /// <param name="newPoint">
        /// The new <see cref="T:DEV_5.Point" />.
        /// </param>
        public void FlyTo(Point newPoint)
        {
            this.RouteList.Add(newPoint);
        }

        /// <inheritdoc />
        /// <summary>
        /// Returns object type
        /// </summary>
        /// <returns>
        /// The <see cref="T:System.Type" />.
        /// </returns>
        public Type WhoAmI()
        {
            return this.GetType();
        }

        /// <inheritdoc />
        /// <summary>
        /// The get fly time.
        /// </summary>
        /// <returns>
        /// elapsed time in hours
        /// </returns>
        /// <exception cref="T:System.ArgumentException">
        /// it is impossible to calculate the flight time if there are less than two points
        /// </exception>
        public double GetFlyTime()
        {
            if (this.RouteList.Count < 2)
            {
                throw new ArgumentException("it is impossible to calculate the flight time if there are less than two points");
            }

            double distance = 0;
            for (var i = 0; i < this.RouteList.Count - 1; i++)
            {
                distance += this.RouteList[i].GetDistance(this.RouteList[i + 1]);
            }

            double flyTime = 0;
            /*
            while (true)
            {
                if (distance > 10)
                {
                    flyTime += 10.0 / this.speed;
                    distance -= 10;
                    this.speed += 10;
                }
                else
                {
                    flyTime += distance / this.speed;
                    break;
                }
            }
            */
            double acceleration = 205;
            flyTime = Math.Pow((4 * this.speed * this.speed) + (8 * acceleration * distance), 0.5) + (-2 * this.speed);
            flyTime = flyTime / 2 / acceleration;

            return flyTime;
        }
    }
}
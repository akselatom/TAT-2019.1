
namespace DEV_5
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The space ship.
    /// </summary>
    public class SpaceShip : IFlyable
    {
        /// <summary>
        /// The SpaceShip speed
        /// </summary>
        private const int Speed = 8000;

        /// <summary>
        /// Initializes a new instance of the <see cref="SpaceShip"/> class.
        /// </summary>
        public SpaceShip()
        {
            this.RouteList = new List<Point> { new Point(new float[] { 0, 0, 0 }) };
        }

        /// <summary>
        /// Gets all <see cref="Point"/> in which there was a <see cref="Bird"/>
        /// </summary>
        public List<Point> RouteList { get; private set; }

        /// <inheritdoc />
        /// <summary>
        /// Adds a new point to <see cref="P:DEV_5.SpaceShip.RouteList" />
        /// </summary>
        /// <param name="newPoint">
        /// The new point.
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
        public double GetFlyTime()
        {
            var distance = Point.GetDistanceInPointList(this.RouteList);
            return distance / Speed;
        }
    }
}
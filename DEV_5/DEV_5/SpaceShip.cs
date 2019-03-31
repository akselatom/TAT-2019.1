
namespace DEV_5
{
    using System;

    /// <inheritdoc />
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
        /// The distance traveled.
        /// </summary>
        private double distanceTraveled;

        /// <summary>
        /// The current bird dislocation.
        /// </summary>
        private Point currentPoint;

        /// <summary>
        /// Initializes a new instance of the <see cref="SpaceShip"/> class.
        /// </summary>
        public SpaceShip()
        {
            this.currentPoint = new Point(new float[] { 0, 0, 0 });
            this.distanceTraveled = 0;
        }

        /// <inheritdoc />
        public event EventHandler<ObjectFlewArgs> ObjectFlew;

        /// <inheritdoc />
        public void FlyTo(Point newPoint)
        {
            this.distanceTraveled = this.currentPoint.GetDistance(newPoint);
            var onObjectFlew = this.ObjectFlew;
            if (onObjectFlew != null)
            {
                onObjectFlew.Invoke(this.WhoAmI(), new ObjectFlewArgs(this.GetFlyTime()));
            }

            this.currentPoint = newPoint;
        }

        /// <inheritdoc />
        public IFlyable WhoAmI()
        {
            return this;
        }

        /// <inheritdoc />
        public double GetFlyTime()
        {
            return this.distanceTraveled / Speed;
        }
    }
}
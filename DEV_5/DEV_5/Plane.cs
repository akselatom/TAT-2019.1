
namespace DEV_5
{
    using System;

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
        /// The distance traveled.
        /// </summary>
        private double distanceTraveled;

        /// <summary>
        /// The current bird dislocation.
        /// </summary>
        private Point currentPoint;

        /// <summary>
        /// Initializes a new instance of the <see cref="Plane"/> class.
        /// </summary>
        public Plane()
        {
            this.currentPoint = new Point(new float[] { 0, 0, 0 });
            this.speed = 200;
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
            var distance = this.distanceTraveled;
            double flyTime = 0;
            const int PathSection = 10;
            while (true)
            {
                if (distance > PathSection)
                {
                    flyTime += PathSection / (double)this.speed;
                    distance -= PathSection;
                    this.speed += PathSection;
                }
                else
                {
                    flyTime += distance / this.speed;
                    break;
                }
            }

            // physically correct calculation
            // double acceleration = 205;
            // flyTime = Math.Pow((4 * this.speed * this.speed) + (8 * acceleration * distance), 0.5) + (-2 * this.speed);
            // flyTime = flyTime / 2 / acceleration;
            return flyTime;
        }
    }
}
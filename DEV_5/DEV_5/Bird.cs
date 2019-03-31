namespace DEV_5
{
    using System;

    /// <inheritdoc />
    /// <summary>
    /// The bird.
    /// </summary>
    public class Bird : IFlyable
    {
        /// <summary>
        /// Birds current speed.
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
        /// Initializes a new instance of the <see cref="Bird"/> class. The initial position of the bird x:0 y:0 z:0
        /// </summary>
        public Bird()
        {
            this.currentPoint = new Point(new float[] { 0, 0, 0 });
            this.distanceTraveled = 0;
            this.speed = new Random().Next(0, 21);
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
            return this.distanceTraveled / this.speed;
        }
    }
}
namespace DEV_5
{
    using System;
    using System.Collections.Generic;

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
        /// Initializes a new instance of the <see cref="Bird"/> class. The initial position of the bird x:0 y:0 z:0
        /// </summary>
        public Bird()
        {
            this.RouteList = new List<Point> { new Point(new float[] { 0, 0, 0 }) };
            this.GenerateNewRandomSpeed();
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
            while (true)
            {
                // compares the distance traveled in an hour with all distance
                if (this.speed < distance)
                {   
                    flyTime += 1;
                    distance -= this.speed;
                    this.GenerateNewRandomSpeed();
                }
                else
                {
                    flyTime += distance / this.speed;
                    break;
                }
            }

            return flyTime;
        }

        /// <summary>
        /// The generate new random speed.
        /// </summary>
        private void GenerateNewRandomSpeed()
        {
            var rand  = new Random();
            this.speed = rand.Next(0, 21); // bird speed varies from 0 km/h to 20
        }
    }
}
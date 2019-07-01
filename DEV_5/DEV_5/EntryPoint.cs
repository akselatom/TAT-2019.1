
namespace DEV_5
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// The entry point.
    /// </summary>
    public class EntryPoint
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            var flyables = new List<IFlyable> { new Bird(), new Plane(), new SpaceShip() };
            var oX = 100;
            var oY = 200;
            var oZ = 800;
            
            foreach (var flyable in flyables)
            {
                flyable.ObjectFlew += ShowFlyTime;
                flyable.FlyTo(new Point(new float[] { oX, oY, oZ }));
            }
        }

        /// <summary>
        /// The method that displays the flight time to the new point in the console.
        /// </summary>
        /// <param name="obj">
        /// The obj.
        /// </param>
        /// <param name="args">
        /// Event argument <see cref="ObjectFlewArgs"/>
        /// </param>
        public static void ShowFlyTime(object obj, ObjectFlewArgs args)
        {
            Console.WriteLine(obj.GetType().Name);
            Console.WriteLine("Elapsed time in hours:{0:0.##}", args.ElapsedTime);
        }
    }
}

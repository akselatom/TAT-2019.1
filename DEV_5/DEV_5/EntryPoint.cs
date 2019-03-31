
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
            foreach (var flyable in flyables)
            {
                flyable.FlyTo(new Point(new float[] { 100, 200, 800 }));
                Console.WriteLine(flyable.GetFlyTime());
                Console.WriteLine(flyable.WhoAmI());
            }
        }
    }
}


namespace DEV_5
{
    using System;

    class EntryPoint
    {
        static void Main(string[] args)
        {
            var newBird = new Bird();
            newBird.FlyTo(new Point(new float[] { 100, 200, 800 }));
            var newPlane = new Plane();
            newPlane.FlyTo(new Point(new float[] { 100, 200, 800 }));
            Console.WriteLine(newPlane.GetFlyTime());
        }
    }
}

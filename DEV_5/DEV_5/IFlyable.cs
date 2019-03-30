
namespace DEV_5
{
    using System;

    /// <summary>
    /// The Flyable interface.
    /// </summary>
    public interface IFlyable
    {
        /// <summary>
        /// The fly to new <see cref="Point"/>.
        /// </summary>
        /// <param name="newPoint">
        /// The new point.
        /// </param>
        void FlyTo(Point newPoint);

        /// <summary>
        /// method returning object type
        /// </summary>
        /// <returns>
        /// The <see cref="Type"/>.
        /// </returns>
        Type WhoAmI();

        /// <summary>
        /// The get fly time.
        /// </summary>
        /// <returns>
        /// The <see cref="float"/>.
        /// </returns>
        double GetFlyTime();
    }
}

namespace DEV_5
{
    using System;

    /// <summary>
    /// The Flyable interface.
    /// </summary>
    public interface IFlyable
    {
        /// <summary>
        /// The object flew.
        /// </summary>
        event EventHandler<ObjectFlewArgs> ObjectFlew;

        /// <summary>
        /// The fly to new <see cref="Point"/>.
        /// </summary>
        /// <param name="newPoint">
        /// The new point.
        /// </param>
        void FlyTo(Point newPoint);

        /// <summary>
        /// Reference of current object
        /// </summary>
        /// <returns>
        /// Returns reference of current object
        /// </returns>
        IFlyable WhoAmI();

        /// <summary>
        /// Returns the time spent on <see cref="FlyTo"/>
        /// </summary>
        /// <returns>
        /// Returns elapsed time.
        /// </returns>
        double GetFlyTime();
    }
}

namespace DEV_5
{
    /// <summary>
    /// The <see cref="P:DEV_5.IFlyable.ObjectFlew"/> event args.
    /// </summary>
    public class ObjectFlewArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectFlewArgs"/> class.
        /// </summary>
        /// <param name="elapsedTime">
        /// The elapsed time.
        /// </param>
        public ObjectFlewArgs(double elapsedTime)
        {
            this.ElapsedTime = elapsedTime;
        }

        /// <summary>
        /// Gets or sets elapsed time in hours.
        /// </summary>
        public double ElapsedTime { get; set; }
    }
}
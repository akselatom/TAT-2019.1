namespace CW_3
{
    /// <summary>
    /// The abstract figure builder.
    /// </summary>
    public abstract class FigureBuilder
    {
        /// <summary>
        /// Gets or sets a successor.
        /// </summary>
        public FigureBuilder Successor { get; protected set; }

        /// <summary>
        /// The create triangle.
        /// </summary>
        /// <param name="a">
        /// Triangle coordinates 
        /// </param>
        /// <param name="b">
        /// Triangle coordinates
        /// </param>
        /// <param name="c">
        /// Triangle coordinates
        /// </param>
        /// <returns>
        /// Initializes a new instance <see cref="Triangle"/>.
        /// </returns>
        public abstract Triangle CreateTriangle(Point a, Point b, Point c);
    }
}
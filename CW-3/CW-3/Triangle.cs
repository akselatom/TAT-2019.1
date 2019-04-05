namespace CW_3
{
    /// <summary>
    /// a class that describes a triangle
    /// </summary>
    public abstract class Triangle
    {
        /// <summary>
        /// The ab side length
        /// </summary>
        public readonly double AB;

        /// <summary>
        /// The bc side length
        /// </summary>
        public readonly double BC;

        /// <summary>
        /// The ac side length
        /// </summary>
        public readonly double AC;

        /// <summary>
        /// Initializes a new instance of the <see cref="Triangle"/> class By three points
        /// </summary>
        /// <param name="a">
        /// <see cref="Point"/> a
        /// </param>
        /// <param name="b">
        /// <see cref="Point"/> b
        /// </param>
        /// <param name="c">
        /// <see cref="Point"/> c
        /// </param>
        protected Triangle(Point a, Point b, Point c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.AB = this.A.GetDistanceBetween(this.B);
            this.BC = this.B.GetDistanceBetween(this.C);
            this.AC = this.A.GetDistanceBetween(this.C);
        }

        /// <inheritdoc cref="Point" />
        public Point A { get; private set; }

        /// <inheritdoc cref="Point" />
        public Point B { get; private set; }

        /// <inheritdoc cref="Point" />
        public Point C { get; private set; }

        /// <summary>
        /// get the area of ​​a triangle
        /// </summary>
        /// <returns>
        /// area of ​​a triangle
        /// </returns>
        public abstract double GetArea();

        /// <summary>
        /// get triangle type
        /// </summary>
        /// <returns>
        /// triangle type
        /// </returns>
        public abstract string GetTriangleType();
    }
}
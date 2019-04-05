namespace DEV_3
{
    /// <inheritdoc />
    /// <summary>
    /// The middle.
    /// </summary>
    public class Middle : Junior
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:DEV_3.Middle" /> class.
        /// </summary>
        public Middle()
        {
            this.Salary = 75;
            this.Productivity = 20;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Middle"/> class.
        /// </summary>
        /// <param name="firstName">
        /// The first name.
        /// </param>
        /// <param name="secondName">
        /// The second name.
        /// </param>
        public Middle(string firstName = "test", string secondName = "test")
            : base(firstName, secondName)
        {
            this.Salary = 75;
            this.Productivity = 20;
        }
    }
}
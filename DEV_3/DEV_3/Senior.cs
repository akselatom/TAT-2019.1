namespace DEV_3
{
    /// <summary>
    /// The senior.
    /// </summary>
    public class Senior : Middle
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Senior"/> class.
        /// </summary>
        public Senior()
        {
            this.Salary = 100;
            this.Productivity = 30;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Senior"/> class.
        /// </summary>
        /// <param name="firstName">
        /// The first name.
        /// </param>
        /// <param name="secondName">
        /// The second name.
        /// </param>
        public Senior(string firstName = "test", string secondName = "test")
            : base(firstName, secondName)
        {
            this.Salary = 100;
            this.Productivity = 30;
        }
    }
}
namespace DEV_3
{
    /// <summary>
    /// The lead.
    /// </summary>
    public class Lead : Senior
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Lead"/> class.
        /// </summary>
        public Lead()
        {
            this.Salary = 180;
            this.Productivity = 50;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Lead"/> class.
        /// </summary>
        /// <param name="firstName">
        /// The first name.
        /// </param>
        /// <param name="secondName">
        /// The second name.
        /// </param>
        public Lead(string firstName = "test", string secondName = "test")
            : base(firstName, secondName)
        {
            this.Salary = 180;
            this.Productivity = 50;
        }   
    }
}
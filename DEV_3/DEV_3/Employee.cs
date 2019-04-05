namespace DEV_3
{
    using System.Text;

    /// <summary>
    /// The employee.
    /// </summary>
    public abstract class Employee
    {
        /// <summary>
        /// The first name.
        /// </summary>
        private readonly string firstName;

        /// <summary>
        /// The second name.
        /// </summary>
        private readonly string secondName;

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        protected Employee()
        {
            this.firstName = "name";
            this.secondName = "secondName";    
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Employee"/> class.
        /// </summary>
        /// <param name="firstName">
        /// The first name.
        /// </param>
        /// <param name="secondName">
        /// The second name.
        /// </param>
        protected Employee(string firstName = "test", string secondName = "test")
        {
            this.firstName = firstName;
            this.secondName = secondName;
        }

        /// <summary>
        /// Gets a employee full name.
        /// </summary>
        public string GetName => this.firstName + " " + this.secondName;

        /// <summary>
        /// All <see cref="Employee"/> field information
        /// </summary>
        /// <returns>Format string with <see cref="Employee"/> information</returns>
        public virtual string GetInfo()
        {
            StringBuilder outputString = new StringBuilder();
            outputString.AppendFormat(this.GetName);
            outputString.Append(" ");
            outputString.AppendFormat(this.GetType().ToString().Substring(this.GetType().ToString().LastIndexOf('.')));
            return outputString.ToString();
        }
    }
}
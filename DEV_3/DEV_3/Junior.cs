namespace DEV_3
{
    using System.Text;

    /// <inheritdoc />
    /// <summary>
    /// The junior. 
    /// </summary>
    public class Junior : Employee
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:DEV_3.Junior" /> class.
        /// </summary>
        public Junior()
        {
            this.Salary = 50;
            this.Productivity = 15;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Junior"/> class.
        /// </summary>
        /// <param name="firstName">
        /// The first name.
        /// </param>
        /// <param name="secondName">
        /// The second name.
        /// </param>
        public Junior(string firstName = "test", string secondName = "test")
            : base(firstName, secondName)
        {
            this.Salary = 50;
            this.Productivity = 15;
        }

        /// <summary>
        /// Gets or sets salary.
        /// </summary>
        public int Salary { get; protected set; }

        /// <summary>
        /// Gets or sets productivity.
        /// </summary>
        public int Productivity { get; protected set; }

        /// <summary>
        /// Gets the efficiency coefficient.
        /// </summary>
        public double GetEfficiencyCoefficient => this.Productivity / (double)this.Salary;

        /// <summary>
        /// All <see cref="Junior"/> field information
        /// </summary>
        /// <returns>Format string with <see cref="Junior"/> information</returns>
        public override string GetInfo()
        {
            StringBuilder outputString = new StringBuilder();
            outputString.AppendFormat(this.GetName);
            outputString.Append(" ");
            outputString.AppendFormat(this.GetType().ToString().Substring(this.GetType().ToString().LastIndexOf('.')));
            outputString.AppendFormat(" Productivity:{0} , Salary:{1}", this.Productivity, this.Salary);
            return outputString.ToString();
        }
    }
}
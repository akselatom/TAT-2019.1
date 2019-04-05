namespace DEV_3
{
    /// <summary>
    /// The customer.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        /// <param name="availableMoney">
        /// The available money.
        /// </param>
        /// <param name="requiredProductivity">
        /// The required productivity.
        /// </param>
        public Customer(int availableMoney, int requiredProductivity)
        {
            this.AvailableMoney = availableMoney;
            this.RequiredProductivity = requiredProductivity;
        }

        /// <summary>
        /// Gets customers available money.
        /// </summary>
        public int AvailableMoney { get; private set; }

        /// <summary>
        /// Gets required productivity.
        /// </summary>
        public int RequiredProductivity { get; private set; }
    } 
}
namespace DEV_3
{
    using System.Collections.Generic;

    /// <summary>
    /// The сustomer.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// The customers available money.
        /// </summary>
        private int availableMoney;

        /// <summary>
        /// The required productivity.
        /// </summary>
        private int requiredProductivity;


        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        /// <param name="availableMoney">
        /// The available money.
        /// </param>
        /// <param name="requiredProductivity">
        /// The required productivity.
        public Customer(int availableMoney, int requiredProductivity)
        {
            this.availableMoney = availableMoney;
            this.requiredProductivity = requiredProductivity;
        }
        
        public int GetAvailableMoney
        {
            get
            {
                return this.availableMoney;
            }
        }

        public int GetRequiredProductivity
        {
            get
            {
                return this.requiredProductivity;
            }
        }
    } 
}
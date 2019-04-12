namespace DEV_6
{
    using System;

    /// <summary>
    /// command that calculates the average cost of cars of a particular brand in <see cref="AutoDatabase"/>
    /// </summary>
    public class CommandGetAvrPriceByBrand : IConsoleCommand
    {
        /// <summary>
        /// The data.
        /// </summary>
        private readonly AutoDatabase data;

        /// <summary>
        /// Gets or sets the brand name.
        /// </summary>
        private readonly string brandName;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandGetAvrPriceByBrand"/> class.
        /// </summary>
        /// <param name="data">
        /// The data.
        /// </param>
        /// <param name="brandName">
        /// The brand name.
        /// </param>
        public CommandGetAvrPriceByBrand(AutoDatabase data, string brandName)
        {
            this.data = data;
            this.brandName = brandName;
        }

        /// <summary>
        /// calculates the average cost of cars of a particular brand in <see cref="AutoDatabase"/>
        /// </summary>
        public void Execute()
        {
            Console.WriteLine("Average Price of {0} cars: {1}", this.brandName, this.data.GetAveragePriceOfAllAutomobiles(this.brandName));
        }
    }
}
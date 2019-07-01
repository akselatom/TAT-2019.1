namespace DEV_6
{
    using System;

    /// <summary>
    /// command that count average price of cars in <see cref="AutoDatabase"/>
    /// </summary>
    public class CommandGetAveragePrice : IConsoleCommand
    {
        /// <summary>
        /// The data.
        /// </summary>
        private readonly AutoDatabase data;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandGetAveragePrice"/> class.
        /// </summary>
        /// <param name="data">
        /// The data.
        /// </param>
        public CommandGetAveragePrice(AutoDatabase data)
        {
            this.data = data;
        }

        /// <summary>
        /// count average price of cars in <see cref="AutoDatabase"/>
        /// </summary>
        public void Execute()
        {
            Console.WriteLine("Average Price of all cars: {0}", this.data.GetAveragePriceOfAllAutomobiles());
        }
    }
}
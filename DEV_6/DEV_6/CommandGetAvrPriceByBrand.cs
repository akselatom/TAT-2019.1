namespace DEV_6
{
    using System;
    using System.Linq;

    /// <summary>
    /// command that calculates the average cost of cars of a particular brand in <see cref="AutoDatabase"/>
    /// </summary>
    public class CommandGetAvrPriceByBrand : IConsoleCommand
    {
        /// <summary>
        /// Gets or sets the brand name.
        /// </summary>
        public string BrandName { get; set; }

        /// <summary>
        /// calculates the average cost of cars of a particular brand in <see cref="AutoDatabase"/>
        /// </summary>
        /// <param name="data">
        /// A <see cref="AutoDatabase"/>
        /// </param>
        public void Execute(AutoDatabase data)
        {
            Console.WriteLine("Average Price of {0} cars: {1}", this.BrandName, data.GetAveragePriceOfAllAutomobiles(this.BrandName.Split(' ').Last()));
        }

    }
}
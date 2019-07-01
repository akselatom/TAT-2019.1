namespace DEV_6
{
    using System;

    /// <summary>
    /// command that count average price of cars in <see cref="AutoDatabase"/>
    /// </summary>
    public class CommandGetAveragePrice : IConsoleCommand
    {
        /// <summary>
        /// count average price of cars in <see cref="AutoDatabase"/>
        /// </summary>
        /// <param name="data">
        /// A <see cref="AutoDatabase"/> object.
        /// </param>
        public void Execute(AutoDatabase data)
        {
            Console.WriteLine("Average Price of all cars: {0}", data.GetAveragePriceOfAllAutomobiles());
        }
    }
}
namespace DEV_6
{
    using System;

    /// <summary>
    /// command that calculates the average cost of cars of a particular brand in <see cref="AutoDatabase"/>
    /// </summary>
    public class CommandGetAvrPriceByBrand: IConsoleCommand
    {
        /// <summary>
        /// calculates the average cost of cars of a particular brand in <see cref="AutoDatabase"/>
        /// </summary>
        /// <param name="data">
        /// A <see cref="AutoDatabase"/>
        /// </param>
        public void Execute(AutoDatabase data)
        {
            Console.WriteLine("Please input brand name:");
            Console.ReadLine();
            Console.WriteLine(
                "Average price of {0} cars : {1}",
                Console.ReadLine(),
                data.GetAveragePriceOfAllAutomobiles());
        }
    }
}
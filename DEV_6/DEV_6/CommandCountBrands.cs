namespace DEV_6
{
    using System;

    /// <summary>
    /// command that count amount of brands in <see cref="AutoDatabase"/>
    /// </summary>
    public class CommandCountBrands: IConsoleCommand
    {
        /// <summary>
        /// Count amount of auto in <see cref="AutoDatabase"/>
        /// </summary>
        /// <param name="data">
        /// A <see cref="AutoDatabase"/>
        /// </param>
        public void Execute(AutoDatabase data)
        {
            Console.WriteLine("Amount of brands: {0}", data.GetAmountOfBrands());
        }
    }
}
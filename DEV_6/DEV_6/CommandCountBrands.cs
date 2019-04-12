namespace DEV_6
{
    using System;

    /// <summary>
    /// command that count amount of brands in <see cref="AutoDatabase"/>
    /// </summary>
    public class CommandCountBrands : IConsoleCommand
    {
        /// <summary>
        /// The data.
        /// </summary>
        private readonly AutoDatabase data;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandCountBrands"/> class.
        /// </summary>
        /// <param name="data">
        /// The data.
        /// </param>
        public CommandCountBrands(AutoDatabase data)
        {
            this.data = data;
        }

        /// <summary>
        /// Count amount of auto in <see cref="AutoDatabase"/>
        /// </summary>
        public void Execute()
        {
            Console.WriteLine("Amount of brands: {0}", this.data.GetAmountOfBrands());
        }
    }
}
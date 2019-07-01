namespace DEV_6
{
    using System;

    /// <summary>
    /// command that count amount of auto in <see cref="AutoDatabase"/>
    /// </summary>
    public class CommandCountAmountOfAuto : IConsoleCommand
    {
        /// <summary>
        /// The data.
        /// </summary>
        private readonly AutoDatabase data;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandCountAmountOfAuto"/> class.
        /// </summary>
        /// <param name="data">
        /// The data.
        /// </param>
        public CommandCountAmountOfAuto(AutoDatabase data)
        {
            this.data = data;
        }

        /// <summary>
        /// The execute <see cref="AutoDatabase"/> GetAmountOfAutomobiles() method.
        /// </summary>
        public void Execute()
        {
            Console.WriteLine("Amount of cars: {0}", this.data.GetAmountOfAutomobiles());
        }
    }
}
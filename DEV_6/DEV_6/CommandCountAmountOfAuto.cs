namespace DEV_6
{
    using System;

    /// <summary>
    /// command that count amount of auto in <see cref="AutoDatabase"/>
    /// </summary>
    public class CommandCountAmountOfAuto : IConsoleCommand
    {
        /// <summary>
        /// The execute <see cref="AutoDatabase"/> GetAmountOfAutomobiles() method.
        /// </summary>
        /// <param name="data">
        /// The data.
        /// </param>
        public void Execute(AutoDatabase data)
        {
            Console.WriteLine("Amount of cars: {0}", data.GetAmountOfAutomobiles());
        }
    }
}
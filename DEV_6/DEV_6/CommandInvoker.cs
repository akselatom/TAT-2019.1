namespace DEV_6
{
    using System;

    /// <summary>
    /// The command invoker.
    /// </summary>
    public class CommandInvoker
    {
        /// <summary>
        /// A <see cref="AutoDatabase"/>
        /// </summary>
        private readonly AutoDatabase data;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandInvoker"/> class.
        /// </summary>
        /// <param name="xmlName">
        /// The xml path.
        /// </param>
        public CommandInvoker(string xmlName)
        {
            this.ConsoleCommand = new IConsoleCommand[]
                                      {
                                          new CommandCountBrands(), new CommandCountAmountOfAuto(),
                                          new CommandGetAveragePrice(), new CommandGetAvrPriceByBrand(),
                                      };
            this.data = new AutoDatabase(xmlName);
        }

        /// <summary>
        /// Gets or sets console commands.
        /// </summary>
        public IConsoleCommand[] ConsoleCommand { get; set; }

        /// <summary>
        /// Provides user interface.
        /// </summary>
        public void ProvideUserInterface()
        {
            Console.WriteLine("Input Command: ");
            var consoleInput = Console.ReadLine();
            while (consoleInput != null && consoleInput.ToLower() != "exit") 
            {
                if (consoleInput == "count types")
                {
                    this.ConsoleCommand[0].Execute(this.data);
                }
                else if (consoleInput == "count all")
                {
                    this.ConsoleCommand[1].Execute(this.data);
                }
                else if (consoleInput == "average price")
                {
                    this.ConsoleCommand[2].Execute(this.data);
                }
                else if (consoleInput.Contains("average price"))
                {
                    var consoleCommand = new CommandGetAvrPriceByBrand { BrandName = consoleInput };
                    this.ConsoleCommand[3] = consoleCommand;
                    this.ConsoleCommand[3].Execute(this.data);
                }
                else
                {
                    Console.WriteLine("Invalid command input. Available commands : count types, count all, average price, average price type");
                }

                consoleInput = Console.ReadLine();
            }
        }
    }
}
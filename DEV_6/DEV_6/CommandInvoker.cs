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
            this.data = new AutoDatabase(xmlName);
        }

        /// <summary>
        /// Witch types of command can be processed by <see cref="CommandInvoker.ExecuteCommands"/>
        /// </summary>
        /// <param name="data">
        /// The data.
        /// </param>
        public delegate void OnAddedCommand(AutoDatabase data);

        /// <summary>
        /// Execute all <see cref="IConsoleCommand"/> commands
        /// </summary>
        public event OnAddedCommand ExecuteCommands;

        /// <summary>
        /// Gets or sets console commands.
        /// </summary>
        public IConsoleCommand ConsoleCommand { get; set; }

        /// <summary>
        /// Provides user interface.
        /// </summary>
        public void ProvideUserInterface()
        {
            Console.WriteLine("Input Command: ");
            var consoleInput = Console.ReadLine();
            while (consoleInput != null && consoleInput.ToLower() != "exit") 
            {
                switch (consoleInput)
                {
                    case "count types":
                        this.ConsoleCommand = new CommandCountBrands();
                        break;
                    case "count all":
                        this.ConsoleCommand = new CommandCountAmountOfAuto();
                        break;
                    case "average price":
                        this.ConsoleCommand = new CommandGetAveragePrice();
                        break;
                    case "execute":
                        consoleInput = null;
                        this.ConsoleCommand = null;
                        continue;
                    default:
                        {
                            if (consoleInput.Contains("average price"))
                            {
                                var consoleCommand = new CommandGetAvrPriceByBrand { BrandName = consoleInput };
                                this.ConsoleCommand = consoleCommand;
                            }
                            else
                            {
                                Console.WriteLine("Invalid command input. Available commands : count types, count all, average price, average price type");
                                consoleInput = Console.ReadLine();
                            }
                            continue;
                        }
                }

                this.ExecuteCommands += this.ConsoleCommand.Execute;  
                consoleInput = Console.ReadLine();
            }
            if (this.ExecuteCommands != null)
            {
                this.ExecuteCommands(this.data);
            }
        }
    }
}
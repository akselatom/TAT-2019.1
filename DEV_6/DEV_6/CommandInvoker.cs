namespace DEV_6
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// The command invoker.
    /// </summary>
    public class CommandInvoker
    {
        /// <summary>
        /// A <see cref="AutoDatabase"/>
        /// </summary>
        private readonly List<AutoDatabase> data;

        /// <summary>
        /// Execute all <see cref="IConsoleCommand"/> commands
        /// </summary>
        private Action executeCommands;

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandInvoker"/> class.
        /// </summary>
        /// <param name="xmlNameAuto">
        /// Name of xml file that contains information about auto
        /// </param>
        /// <param name="xmlNameTruck">
        /// Name of xml file that contains information about trucks
        /// </param>
        public CommandInvoker(string xmlNameAuto, string xmlNameTruck)
        {
            this.data = new List<AutoDatabase> { new AutoDatabase(xmlNameAuto), new AutoDatabase(xmlNameTruck) };
        }

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
            //// by default using xml list with passenger cars
            int indexOfXmlFileInList = 0;
            var consoleInput = new StringBuilder(Console.ReadLine());
            while (consoleInput != null && consoleInput.ToString() != "exit") 
            {
                if (consoleInput.ToString().Contains("truck"))
                {
                    consoleInput.Replace("_truck", string.Empty);
                    indexOfXmlFileInList = 1;
                }

                if (consoleInput.ToString().Contains("car"))
                {
                    consoleInput.Replace("_car", string.Empty);
                    indexOfXmlFileInList = 0;
                }

                switch (consoleInput.ToString())
                {
                    case "count_types":
                        this.ConsoleCommand = new CommandCountBrands(this.data[indexOfXmlFileInList]);
                        break;
                    case "count_all":
                        this.ConsoleCommand = new CommandCountAmountOfAuto(this.data[indexOfXmlFileInList]);
                        break;
                    case "average_price":
                        this.ConsoleCommand = new CommandGetAveragePrice(this.data[indexOfXmlFileInList]);
                        break;
                    case "execute":
                        consoleInput = null;
                        this.ConsoleCommand = null;
                        continue;
                    default:
                        {
                            if (consoleInput.ToString().Contains("average_price"))
                            {
                                var consoleCommand = new CommandGetAvrPriceByBrand(
                                    this.data[indexOfXmlFileInList],
                                    consoleInput.ToString().Split(' ').Last());
                                this.ConsoleCommand = consoleCommand;
                            }

                            Console.WriteLine("Invalid command input. Available commands : count_types_truck(car), count_all_truck(car), average_price_truck(car), average_price_truck(car)_type");
                            consoleInput.Clear();
                            consoleInput.Append(Console.ReadLine());
                            continue;
                        }
                }

                this.executeCommands += this.ConsoleCommand.Execute;  
                consoleInput.Clear();
                consoleInput.Append(Console.ReadLine());
            }

            if (this.executeCommands != null)
            {
                this.executeCommands();
            }
        }
    }
}
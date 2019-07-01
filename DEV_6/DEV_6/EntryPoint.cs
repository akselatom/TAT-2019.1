
namespace DEV_6
{
    using System;

    /// <summary>
    /// The main class.
    /// Contains a entry point method of program.
    /// the program loads car information from xml file and provides some methods for working with this information
    /// </summary>
    public class EntryPoint
    {
        /// <summary>
        /// The entry point of the program
        /// </summary>
        /// <param name="args">
        /// xml file name
        /// </param>
        public static void Main(string[] args)
        {
            if (args.Length != 0 && args[0] != string.Empty)
            {
                var userInterface = new CommandInvoker(args[0], args[1]);
                userInterface.ProvideUserInterface();
            }
            else
            {
                Console.WriteLine("Empty argument string!");
            }
        }
    }
}


namespace DEV_1
{
    using System;

    /// <summary>
    /// The main class.
    /// Contains a entry point method of program.
    /// </summary>
    public class Dev1
    {
        /// <summary>
        /// The entry point of the program
        /// </summary>
        /// <param name="args">Entry string.Specified in the input argument string</param>
        public static void Main(string[] args)
        {
            try
            {
                if (args.Length != 0 && args[0].Length > 1)
                {
                    var testClass = new UniqueSymbolsFinder(args[0]);
                    foreach (var uniqueSymbols in testClass.GetUniqueSymbolsSequence().Split())
                    {
                        Console.WriteLine(uniqueSymbols);
                    }
                }
                else
                {
                    throw new ArgumentException("input line is empty or too short(length < 2)");
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}

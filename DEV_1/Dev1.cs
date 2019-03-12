
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
                var testClass = new UniqueSymbolsFinder(args[0]);
                if (testClass.CheckStringLength())
                {
                    foreach (var uniqueSymbols in testClass.GetUniqueSymbolsSequence().Split())
                    {
                        Console.WriteLine(uniqueSymbols);
                    }
                }
                else
                {
                    Console.WriteLine("String is too short Length<2");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}

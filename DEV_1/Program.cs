
namespace DEV_1
{
    using System;

    /// <summary>
    /// The main class.
    /// Contains a entry point method of program.
    /// </summary>
    public class Program
    {

        /// <summary>
        /// The entry point of the program
        /// </summary>
        /// <param name="args">Entry string.Specified in the input argument string</param>
        public static void Main(string[] args)
        {
            string inputString = args[0];
            var testClass = new UniqueSymbols { Enterstirng = inputString };
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
    }
}

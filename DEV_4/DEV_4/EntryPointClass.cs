
namespace DEV_4
{
    using System;

    /// <summary>
    /// The entry point class.
    /// </summary>
    public class EntryPointClass
    {
        /// <summary>
        /// The main. 
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        public static void Main(string[] args)
        {
            string str = " ";
            str = str.GenerateUniqueObjectDescription();
            Console.WriteLine(str);
        }
    }
}

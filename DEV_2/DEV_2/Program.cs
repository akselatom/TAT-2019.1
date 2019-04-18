
namespace DEV_2
{
    using System;

    /// <summary>
    /// The main class.
    /// Contains a entry point method of program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Entry point of program
        /// </summary>
        /// <param name="args">
        /// input string for phoneme processing
        /// </param>
        public static void Main(string[] args)
        {
            try
            {
                if (args == null)
                {
                    throw new NullReferenceException("Null input arguments");
                }

                if (args.Length > 1)
                {
                    throw new ArgumentException("More than one word in args!");
                }
                var replacer = new StringLettersToSoundReplacer(args[0]);
                replacer.VoicingOrStunningConsonantsReplacer();
                replacer.ReplacementUnstressedO();
                replacer.SofteningConsonants();
                Console.WriteLine(replacer.ProcessingVowelsIntoSounds());
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}


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
                if (args.Length < 0 || args[0].Length < 2)
                {
                    throw new IndexOutOfRangeException();
                }

                var inputString = args[0];
                var replacer = new StringLettersToSoundReplacer();
                inputString = replacer.VoicingOrStunningConsonantsReplacer(inputString);
                inputString = replacer.ReplacementUnstressedO(inputString);
                inputString = replacer.SofteningConsonants(inputString);
                inputString = replacer.ProcessingVowelsIntoSounds(inputString);
                Console.WriteLine(inputString);
               
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Empty or too short String!");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}

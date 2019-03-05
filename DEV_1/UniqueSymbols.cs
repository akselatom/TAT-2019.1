
namespace DEV_1
{
    /// <summary>
    /// class that finds and prints combinations of non-repeating symbols.
    /// </summary>
    public class UniqueSymbols
    {
        /// <summary>
        /// The field that contains the input string
        /// </summary>
        public string Enterstirng { get; set; }

        /// <summary>
        /// Check string for length
        /// </summary>
        /// <returns>Returns true if string length more than 1</returns>
        public bool CheckStringLength()
        {
            return this.Enterstirng.Length >= 2;
        }

        /// <summary>
        /// a method that finds unique symbols in a string
        /// </summary>
        /// <returns>Returns a string in which unique characters are separated by a space.</returns>
        public string GetUniqueSymbolsSequence()
        {
            int startUniqueSymbolIndex = 0;
            string uniqueSymbolsSequence = string.Empty;

            for (var i = 0; i < this.Enterstirng.Length - 1; i++)
            {
                if (this.Enterstirng[i] == this.Enterstirng[i + 1])
                {
                    for (var j = startUniqueSymbolIndex; j < i; j++)
                    {
                        uniqueSymbolsSequence += this.Enterstirng[j];
                    }

                    // add a space for future string parsing
                    uniqueSymbolsSequence += " ";
                    startUniqueSymbolIndex = i + 1;
                }
                else if (i == this.Enterstirng.Length - 2)
                {
                    for (var j = startUniqueSymbolIndex; j < i + 2; j++)
                    {
                        uniqueSymbolsSequence += this.Enterstirng[j];
                    }
                    uniqueSymbolsSequence += " ";
                }
            }

            return uniqueSymbolsSequence;
        }
    }
}
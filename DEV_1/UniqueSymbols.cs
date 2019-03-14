
namespace DEV_1
{
    using System;

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
            string uniqueSymbolsSequence = string.Empty;
            string moreThanTwoLetters = string.Empty;

            for (var i = 1; i < this.Enterstirng.Length; i++)
            {
                
                if (this.Enterstirng[i - 1] != this.Enterstirng[i])
                {
                    // remember 2 different characters, if the following comparison is successful, then add one more character to this string
                    if (moreThanTwoLetters.Length == 0)
                    {
                        moreThanTwoLetters += this.Enterstirng[i - 1];
                        moreThanTwoLetters += this.Enterstirng[i];
                    }
                    else
                    {
                        moreThanTwoLetters += this.Enterstirng[i];
                    }
                    
                    uniqueSymbolsSequence += this.Enterstirng[i - 1];
                    uniqueSymbolsSequence += this.Enterstirng[i] + " ";
                }
                else
                {
                    moreThanTwoLetters = string.Empty;

                }

                if (moreThanTwoLetters.Length > 2)
                {
                    uniqueSymbolsSequence += moreThanTwoLetters + " ";
                }

            }
            return uniqueSymbolsSequence;
        }
    }
}
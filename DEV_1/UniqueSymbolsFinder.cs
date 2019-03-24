
namespace DEV_1
{
    using System.Text;

    /// <summary>
    /// class that finds and prints combinations of non-repeating symbols.
    /// </summary>
    public class UniqueSymbolsFinder
    {
        /// <summary>
        /// The field that contains the input string
        /// </summary>
        private readonly string inputString;

        /// <summary>
        /// Initializes a new instance of the <see cref="UniqueSymbolsFinder"/> class.
        /// </summary>
        /// <param name="inputString">
        /// The input string.
        /// </param>
        public UniqueSymbolsFinder(string inputString)
        {
            this.inputString = inputString;
        }

        /// <summary>
        /// a method that finds unique symbols in a string
        /// </summary>
        /// <returns>Returns a string in which unique characters are separated by a space.</returns>
        public string GetUniqueSymbolsSequence()
        {
            var uniqueSymbolsSequence = string.Empty;
            var moreThanTwoLettersSequence = new StringBuilder(string.Empty);

            for (var i = 1; i < this.inputString.Length; i++)
            {
                if (this.inputString[i - 1] != this.inputString[i])
                {
                    //// remember 2 different characters, if the following comparison is successful, then add one more character to this string
                    if (moreThanTwoLettersSequence.Length == 0)
                    {
                        moreThanTwoLettersSequence.Append(this.inputString[i - 1]);
                        moreThanTwoLettersSequence.Append(this.inputString[i]);
                    }
                    else
                    {
                        moreThanTwoLettersSequence.Append(this.inputString[i]);
                    }
                    
                    uniqueSymbolsSequence += this.inputString[i - 1];
                    uniqueSymbolsSequence += this.inputString[i] + " ";
                }
                else
                {
                    ////clear a string after coincidence of characters
                    moreThanTwoLettersSequence.Clear();
                }

                if (moreThanTwoLettersSequence.Length > 2)
                {
                    uniqueSymbolsSequence += moreThanTwoLettersSequence + " ";
                }
            }

            return uniqueSymbolsSequence;
        }
    }
}

namespace DEV_2
{
    using System;
    using System.Linq;
    using System.Text;

    /// <summary>
    ///  Class that handles phoneme input
    /// </summary>
    public class StringLettersToSoundReplacer
    {
        /// <summary>
        /// Processed string
        /// </summary>
        private string inputString;

        /// <summary>
        /// Initializes a new instance of the <see cref="StringLettersToSoundReplacer"/> class.
        /// </summary>
        /// <param name="inputString">
        /// The input string.
        /// </param>
        public StringLettersToSoundReplacer(string inputString)
        {
            if (this.CheckCorrectInputString(inputString))
            {
                this.inputString = inputString.ToLower();
            }
        }

        /// <summary>
        /// The replacement unstressed o.
        /// </summary>
        /// <returns>
        /// Returns string were all unstressed O replaced by A
        /// </returns>
        public string ReplacementUnstressedO()
        {
            this.inputString = this.inputString.Replace('о', 'а');
            this.inputString = this.inputString.Replace("а+", "о+");
            this.inputString = this.inputString.Replace("+", string.Empty);

            return this.inputString;
        }

        /// <summary>
        /// a method that replaces soft consonants with their phonemes
        /// </summary>
        /// <returns>
        /// Returns string were all soft consonants replaced with their phonemes.
        /// </returns>
        public string SofteningConsonants()
        {
            foreach (var keys in RussianDictionary.AllSoftSounds.Keys)
            {
                if (this.inputString.Contains(keys))
                {
                    var replaceString = RussianDictionary.AllSoftSounds[keys];
                    this.inputString = this.inputString.Replace(keys, replaceString);
                }
            }

            return this.inputString;
        }

        /// <summary>
        /// The processing vowels into sounds.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string ProcessingVowelsIntoSounds()
        {
            string tempString = this.FirstLetterToUpperCase();
            bool firstIteration = true;
            foreach (var keys in RussianDictionary.VowelsLettersToPhoneticSounds.Keys)
            {
                //// checking the case when the vowel comes first
                if (firstIteration)
                {
                    string replaceString = RussianDictionary.VowelsLettersToPhoneticSounds[keys];
                    tempString = tempString.Replace(keys, replaceString);
                    firstIteration = false;
                }
                else if (tempString.Contains(keys))
                {
                    string replaceString = RussianDictionary.VowelsLettersToPhoneticSounds[keys];
                    tempString = tempString.Replace(keys, replaceString);
                }
            }

            return tempString.ToLower();
        }

        /// <summary>
        /// A method that stuns or voices paired consonants in a string.
        /// </summary>
        /// <returns>
        /// Returns the string with the completed conversion
        /// </returns>
        public string VoicingOrStunningConsonantsReplacer()
        {
            StringBuilder outputString = new StringBuilder(this.inputString);
            for (int i = 0; i < outputString.Length; i++)
            {
                outputString = this.StunningConsonantReplacer(outputString, i);
                outputString = this.VoicingConsonantReplacer(outputString, i);
            }

            this.inputString = outputString.ToString();
            return this.inputString;
        }

        /// <summary>
        /// The check correct input string.
        /// </summary>
        /// <param name="inputWord">
        /// The input word.
        /// </param>
        /// <returns>
        /// Returns true if input string is correct
        /// </returns>
        /// <exception cref="ArgumentException">
        /// Throws Exception if input string is too short or have unacceptable symbols
        /// </exception>
        public bool CheckCorrectInputString(string inputWord)
        {
            if (inputWord.Length < 2)
            {
                throw new ArgumentException("Too short input word.");
            }

            var numberOfAccents = 0;
            foreach (var letter in inputWord)
            {
                if ((letter < 'а' || letter > 'я') && (letter < 'А' || letter > 'Я') && letter != '+')
                {
                    throw new ArgumentException("only Russian letters and the '+' symbol are allowed.");
                }

                if (letter == '+')
                {
                    numberOfAccents++;
                }
            }

            if (numberOfAccents > 1)
            {
                throw new ArgumentException("Using more than one '+' symbol!");
            }

            return true;
        }

        /// <summary>
        ///  Checks a letter for stunning case
        /// </summary>
        /// <param name="inputStringBuilder">
        /// The input string.
        /// </param>
        /// <param name="letterInd">
        /// checked letter index.
        /// </param>
        /// <returns>
        /// Returns the string with the completed conversion
        /// </returns>
        private StringBuilder StunningConsonantReplacer(StringBuilder inputStringBuilder, int letterInd)
        {
            const string AllVoicingConsonants = "бгджзлмнрй";
            if (letterInd == inputStringBuilder.Length - 1)
            {
                return inputStringBuilder;
            }

            if (RussianDictionary.VoicingAndStunningConsonants.ContainsValue(inputStringBuilder[letterInd]))
            {
                var changeableConsonant = inputStringBuilder[letterInd];
                if (AllVoicingConsonants.Contains(inputStringBuilder[letterInd + 1]))
                {
                    var myKey = RussianDictionary.VoicingAndStunningConsonants.FirstOrDefault(x => x.Value == inputStringBuilder[letterInd]).Key;
                    inputStringBuilder.Replace(changeableConsonant, myKey, letterInd, 1);
                }
            }

            return inputStringBuilder;
        }

        /// <summary>
        /// Checks a letter for voicing case
        /// </summary>
        /// <param name="inputStringBuilder">
        /// The input string.
        /// </param>
        /// <param name="letterInd">
        /// checked letter index.
        /// </param>
        /// <returns>
        /// Returns the string with the completed conversion
        /// </returns>
        private StringBuilder VoicingConsonantReplacer(StringBuilder inputStringBuilder, int letterInd)
        {
            const string AllStunningConsonants = "пфктшсчцчщ";

            if (RussianDictionary.VoicingAndStunningConsonants.ContainsKey(inputStringBuilder[letterInd]))
            {
                var changeableConsonant = inputStringBuilder[letterInd];
                if (letterInd == inputStringBuilder.Length - 1)
                {
                    var myKey = RussianDictionary.VoicingAndStunningConsonants[changeableConsonant];
                    inputStringBuilder.Replace(changeableConsonant, myKey, letterInd, 1);
                }
                else if (AllStunningConsonants.Contains(inputStringBuilder[letterInd + 1]))
                {
                    var myKey = RussianDictionary.VoicingAndStunningConsonants[changeableConsonant];
                    inputStringBuilder.Replace(changeableConsonant, myKey, letterInd, 1);
                }
            }

            return inputStringBuilder;
        }

        /// <summary>
        /// Changes first letter to upper case. Necessary for the correct operation of the <see cref="ProcessingVowelsIntoSounds"/>
        /// in case when vowel comes first
        /// </summary>
        /// <returns>
        /// returns a string with a capital letter
        /// </returns>
        private string FirstLetterToUpperCase()
        {
            return this.inputString.Remove(1, this.inputString.Length - 1).ToUpper() + this.inputString.Remove(0, 1);
        }
    }
}
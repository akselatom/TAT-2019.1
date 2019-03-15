
namespace DEV_2
{
    using System.Linq;
    using System.Text;

    /// <summary>
    ///  Class that handles phoneme input
    /// </summary>
    public class StringLettersToSoundReplacer
    {
        /// <summary>
        /// The replacement unstressed o.
        /// </summary>
        /// <param name="inputString">
        /// The input string.
        /// </param>
        /// <returns>
        /// Returns string were all unstressed O replaced by A
        /// </returns>
        public string ReplacementUnstressedO(string inputString)
        {
            inputString = inputString.Replace('о', 'а');
            inputString = inputString.Replace("а+", "о+");
            inputString = inputString.Replace("+", string.Empty);

            return inputString;
        }

        /// <summary>
        /// a method that replaces soft consonants with their phonemes
        /// </summary>
        /// <param name="inputString">
        /// The input string.
        /// </param>
        /// <returns>
        /// Returns string were all soft consonants replaced with their phonemes.
        /// </returns>
        public string SofteningConsonants(string inputString)
        {
            foreach (var keys in RussianDictionary.AllSoftSounds.Keys)
            {
                if (inputString.Contains(keys))
                {
                    string replaсeString = RussianDictionary.AllSoftSounds[keys];
                    inputString = inputString.Replace(keys, replaсeString);
                }
            }

            return inputString;
        }

        /// <summary>
        /// The processing vowels into sounds.
        /// </summary>
        /// <param name="inputString">
        /// The input string.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public string ProcessingVowelsIntoSounds(string inputString)
        {
            string tempString = this.FirstLetterToUpperCase(inputString);
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

            return tempString;
        }

        /// <summary>
        /// A method that stuns or voices paired consonants in a string.
        /// </summary>
        /// <param name="inputString">
        /// The input string.
        /// </param>
        /// <returns>
        /// Returns the string with the completed conversion
        /// </returns>
        public string VoicingOrStunningConsonantsReplacer(string inputString)
        {
            StringBuilder outputString = new StringBuilder(inputString);
            for (int i = 0; i < outputString.Length; i++)
            {
                outputString = this.StunningConsonantReplacer(outputString, i);
                outputString = this.VoicingConsonantReplacer(outputString, i);
            }

            inputString = outputString.ToString();
            return inputString;
        }

        /// <summary>
        ///  Checks a letter for stunning case
        /// </summary>
        /// <param name="inputString">
        /// The input string.
        /// </param>
        /// <param name="letterInd">
        /// checked letter index.
        /// </param>
        /// <returns>
        /// Returns the string with the completed conversion
        /// </returns>
        private StringBuilder StunningConsonantReplacer(StringBuilder inputString, int letterInd)
        {
            const string AllVoicingConsonants = "бгджзлмнрй";
            if (letterInd == inputString.Length - 1)
            {
                return inputString;
            }

            if (RussianDictionary.VoicingAndStunningConsonants.ContainsValue(inputString[letterInd]))
            {
                var changeableConsonant = inputString[letterInd];
                if (AllVoicingConsonants.Contains(inputString[letterInd + 1]))
                {
                    var myKey = RussianDictionary.VoicingAndStunningConsonants.FirstOrDefault(x => x.Value == inputString[letterInd]).Key;
                    inputString.Replace(changeableConsonant, myKey, letterInd, 1);
                }
            }

            return inputString;
        }

        /// <summary>
        /// Checks a letter for voicing case
        /// </summary>
        /// <param name="inputString">
        /// The input string.
        /// </param>
        /// <param name="letterInd">
        /// checked letter index.
        /// </param>
        /// <returns>
        /// Returns the string with the completed conversion
        /// </returns>
        private StringBuilder VoicingConsonantReplacer(StringBuilder inputString, int letterInd)
        {
            const string AllStunningConsonants = "пфктшсчцчщ";

            if (RussianDictionary.VoicingAndStunningConsonants.ContainsKey(inputString[letterInd]))
            {
                var changeableConsonant = inputString[letterInd];
                if (letterInd == inputString.Length - 1)
                {
                    var myKey = RussianDictionary.VoicingAndStunningConsonants[changeableConsonant];
                    inputString.Replace(changeableConsonant, myKey, letterInd, 1);
                }
                else if (AllStunningConsonants.Contains(inputString[letterInd + 1]))
                {
                    var myKey = RussianDictionary.VoicingAndStunningConsonants[changeableConsonant];
                    inputString.Replace(changeableConsonant, myKey, letterInd, 1);
                }
            }

            return inputString;
        }

        /// <summary>
        /// Changes first letter to upper case. Necessary for the correct operation of the <see cref="ProcessingVowelsIntoSounds"/>
        /// in case the vowel comes first
        /// </summary>
        /// <param name="inputString">
        /// The input string.
        /// </param>
        /// <returns>
        /// returns a string with a capital letter
        /// </returns>
        private string FirstLetterToUpperCase(string inputString)
        {
            return inputString.Remove(1, inputString.Length - 1).ToUpper() + inputString.Remove(0, 1);
        }
    }
}
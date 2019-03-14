﻿
namespace DEV_2
{
    using System.Collections.Generic;
    using System.Linq;

    class RussianPhoneticDictionary
    {
        /// <summary>
        /// A dictionary containing all possible soft consonants variants, except always soft consonants.
        /// </summary>
        public readonly Dictionary<string, string> AllSoftSounds = new Dictionary<string, string>()
                                                                       {
                                                                           { "би", "б'и" },
                                                                           { "ви", "в'и" },
                                                                           { "ги", "г'и" },
                                                                           { "ди", "д'и" },
                                                                           { "зи", "з'и" },
                                                                           { "ки", "к'и" },
                                                                           { "ли", "л'и" },
                                                                           { "ми", "м'и" },
                                                                           { "ни", "н'и" },
                                                                           { "пи", "п'и" },
                                                                           { "ри", "р'и" },
                                                                           { "си", "с'и" },
                                                                           { "ти", "т'и" },
                                                                           { "фи", "ф'и" },
                                                                           { "хи", "х'и" },
                                                                           { "бе", "б'э" },
                                                                           { "ве", "в'э" },
                                                                           { "ге", "г'э" },
                                                                           { "де", "д'э" },
                                                                           { "зе", "з'э" },
                                                                           { "ке", "к'э" },
                                                                           { "ле", "л'э" },
                                                                           { "ме", "м'э" },
                                                                           { "не", "н'э" },
                                                                           { "пе", "п'э" },
                                                                           { "ре", "р'э" },
                                                                           { "се", "с'э" },
                                                                           { "те", "т'э" },
                                                                           { "фе", "ф'э" },
                                                                           { "хе", "х'э" },
                                                                           { "бё", "б'о" },
                                                                           { "вё", "в'о" },
                                                                           { "гё", "г'о" },
                                                                           { "дё", "д'о" },
                                                                           { "зё", "з'о" },
                                                                           { "кё", "к'о" },
                                                                           { "лё", "л'о" },
                                                                           { "мё", "м'о" },
                                                                           { "нё", "н'о" },
                                                                           { "пё", "п'о" },
                                                                           { "рё", "р'о" },
                                                                           { "сё", "с'о" },
                                                                           { "тё", "т'о" },
                                                                           { "фё", "ф'о" },
                                                                           { "хё", "х'о" },
                                                                           { "бю", "б'у" },
                                                                           { "вю", "в'у" },
                                                                           { "гю", "г'у" },
                                                                           { "дю", "д'у" },
                                                                           { "зю", "з'у" },
                                                                           { "кю", "к'у" },
                                                                           { "лю", "л'у" },
                                                                           { "мю", "м'у" },
                                                                           { "ню", "н'у" },
                                                                           { "пю", "п'у" },
                                                                           { "рю", "р'у" },
                                                                           { "сю", "с'у" },
                                                                           { "тю", "т'у" },
                                                                           { "фю", "ф'у" },
                                                                           { "хю", "х'у" },
                                                                           { "бя", "б'а" },
                                                                           { "вя", "в'а" },
                                                                           { "гя", "г'а" },
                                                                           { "дя", "д'а" },
                                                                           { "зя", "з'а" },
                                                                           { "кя", "к'а" },
                                                                           { "ля", "л'а" },
                                                                           { "мя", "м'а" },
                                                                           { "ня", "н'а" },
                                                                           { "пя", "п'а" },
                                                                           { "ря", "р'а" },
                                                                           { "ся", "с'а" },
                                                                           { "тя", "т'а" },
                                                                           { "фя", "ф'а" },
                                                                           { "хя", "х'а" },
                                                                       };

        /// <summary>
        /// dictionary containing all vowels sounds.
        /// </summary>
        public readonly Dictionary<string, string> VowelsLettersToPhoneticSounds = new Dictionary<string, string>()
                                                                                       {
                                                                                           { "Е", "йэ" },
                                                                                           { "Ё", "йо" },
                                                                                           { "Ю", "йу" },
                                                                                           { "Я", "йa" },
                                                                                           { "ъе", "йэ" },
                                                                                           { "ъё", "йо" },
                                                                                           { "ъю", "йу" },
                                                                                           { "ъя", "йа" },
                                                                                           { "ье", "'йэ" },
                                                                                           { "ьё", "'йо" },
                                                                                           { "ью", "'йу" },
                                                                                           { "ья", "'йа" },
                                                                                           { "ее", "эйэ" },
                                                                                           { "её", "эйо" },
                                                                                           { "ею", "эйу" },
                                                                                           { "ея", "эйа" },
                                                                                           { "ёе", "ойэ" },
                                                                                           { "ёю", "ойу" },
                                                                                           { "ёя", "ойа" },
                                                                                           { "юе", "уйэ" },
                                                                                           { "юё", "уйо" },
                                                                                           { "юю", "уйу" },
                                                                                           { "юя", "уйа" },
                                                                                           { "яя", "aйа" },
                                                                                           { "яе", "aйэ" },
                                                                                           { "яё", "aйё" },
                                                                                           { "яю", "aйу" },
                                                                                           { "ае", "айэ" },
                                                                                           { "аё", "айо" },
                                                                                           { "аю", "айу" },
                                                                                           { "ая", "айа" },
                                                                                           { "ое", "ойэ" },
                                                                                           { "оё", "айо" },
                                                                                           { "ою", "ойу" },
                                                                                           { "оя", "ойа" },
                                                                                           { "ие", "ийэ" },
                                                                                           { "иё", "ийо" },
                                                                                           { "ию", "ийу" },
                                                                                           { "ия", "ийа" },
                                                                                           { "ые", "ыйэ" },
                                                                                           { "ыё", "ыйо" },
                                                                                           { "ыю", "ыйу" },
                                                                                           { "ыя", "ыйа" },
                                                                                           { "уе", "уйэ" },
                                                                                           { "уё", "уйо" },
                                                                                           { "ую", "уйу" },
                                                                                           { "уя", "уйа" },
                                                                                           { "эе", "эйэ" },
                                                                                           { "эё", "эйо" },
                                                                                           { "эю", "эйу" },
                                                                                           { "эя", "эйа" },
                                                                                       };

        public readonly Dictionary<char, char> VoicingAndStunningConsonants = new Dictionary<char, char>()
                                                                                  {
                                                                                      { 'б', 'п' },
                                                                                      { 'в', 'ф' },
                                                                                      { 'г', 'к' },
                                                                                      { 'д', 'т' },
                                                                                      { 'ж', 'ш' },
                                                                                      { 'з', 'с' },
                                                                                      { 'л', 'Л' },
                                                                                      { 'м', 'М' },
                                                                                      { 'н', 'Н' },
                                                                                      { 'р', 'Р' },
                                                                                      { 'й', 'Й' },
                                                                                      { 'Х', 'x' },
                                                                                      { 'Ц', 'ц' },
                                                                                      { 'Ч', 'ч' },
                                                                                      { 'Щ', 'щ' },
                                                                                  };

        /// <summary>
        /// The first letter to upper case.
        /// </summary>
        /// <param name="inputString">
        /// The input string.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        private string FirstLetterToUpperCase(string inputString)
        {
            return (string)(inputString.Remove(1, inputString.Length - 1)).ToUpper() + inputString.Remove(0, 1);
        }

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
            inputString = ReplacementUnstressedO(inputString);
            string tempString = FirstLetterToUpperCase(inputString);
            bool firstIteration = true;
            foreach (var keys in this.AllSoftSounds.Keys)
            {
                if (tempString.Contains(keys))
                {
                    string replasestring = this.AllSoftSounds[keys];
                    tempString = tempString.Replace(keys, replasestring);
                }
            }

            foreach (var keys in this.VowelsLettersToPhoneticSounds.Keys)
            {
                //// checking the case when the vowel comes first
                if (firstIteration)
                {
                    string replasestring = this.VowelsLettersToPhoneticSounds[keys];
                    tempString = tempString.Replace(keys, replasestring);
                    firstIteration = false;
                }
                else if (tempString.Contains(keys))
                {
                    
                    string replasestring = this.VowelsLettersToPhoneticSounds[keys];
                    tempString = tempString.Replace(keys, replasestring);
                }
            }

            return tempString;
        }

        public string VoicingOrStunningConsonants(string inputString)
        {
            bool voicingLetter = false;
            bool stunningLetter = false;


            return inputString;
        }
    }
}

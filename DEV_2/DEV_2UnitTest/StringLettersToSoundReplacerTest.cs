namespace DEV_2UnitTest
{
    using DEV_2;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// <see cref="StringLettersToSoundReplacer"/> methods test.
    /// </summary>
    [TestClass]
    public class StringLettersToSoundReplacerTest
    {
        /// <summary>
        /// The replacer.
        /// </summary>
        private StringLettersToSoundReplacer replacer;

        /// <summary>
        /// The enter word test.
        /// </summary>
        /// <param name="word">
        /// The word.
        /// </param>
        /// <param name="expectedResult">
        /// The expected result.
        /// </param>
        [DataRow("злее", "злэйэ")]
        [DataRow("ею", "йэйу")]
        [DataRow("БОЛЬШИЕ", "большийэ")]
        [DataTestMethod]
        public void ProcessingVowelsIntoSoundsTest(string word, string expectedResult)
        {
            this.replacer = new StringLettersToSoundReplacer(word);
            Assert.AreEqual(expectedResult, this.replacer.ProcessingVowelsIntoSounds());
        }

        /// <summary>
        /// The replacement unstressed o test.
        /// </summary>
        /// <param name="word">
        /// The word.
        /// </param>
        /// <param name="expectedResult">
        /// The expected result.
        /// </param>
        [DataRow("молоко+", "малако")]
        [DataRow("оооо+", "ааао")]
        [DataTestMethod]
        public void ReplacementUnstressedOTest(string word, string expectedResult)
        {
            this.replacer = new StringLettersToSoundReplacer(word);
            Assert.AreEqual(expectedResult, this.replacer.ReplacementUnstressedO());
        }

        /// <summary>
        /// The softening consonants test.
        /// </summary>
        /// <param name="word">
        /// The word.
        /// </param>
        /// <param name="expectedResult">
        /// The expected result.
        /// </param>
        [DataRow("место", "м'эсто")]
        [DataRow("ме+сто", "м'э+сто")]
        [DataRow("перее+хал", "п'эр'эе+хал")]
        [DataTestMethod]
        public void SofteningConsonantsTest(string word, string expectedResult)
        {
            this.replacer = new StringLettersToSoundReplacer(word);
            Assert.AreEqual(expectedResult, this.replacer.SofteningConsonants());
        }

        /// <summary>
        /// The voicing or stunning consonants replacer test.
        /// </summary>
        /// <param name="word">
        /// The word.
        /// </param>
        /// <param name="expectedResult">
        /// The expected result.
        /// </param>
        [DataRow("сделать", "зделать")]
        [DataRow("зуб", "зуп")]
        [DataTestMethod]
        public void VoicingOrStunningConsonantsReplacerTest(string word, string expectedResult)
        {
            this.replacer = new StringLettersToSoundReplacer(word);
            Assert.AreEqual(expectedResult, this.replacer.VoicingOrStunningConsonantsReplacer());
        }
    }
}
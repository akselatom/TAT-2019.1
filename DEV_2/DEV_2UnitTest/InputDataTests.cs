
namespace DEV_2UnitTest
{
    using System;

    using DEV_2;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// The input data tests.
    /// </summary>
    [TestClass]
    public class InputDataTests
    {
        /// <summary>
        /// The null input string test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void NullInputStringTest()
        {
            Program.Main(null);    
        }

        /// <summary>
        /// The word length less than 2 test
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void WordLengthLessThan2Test()
        {
            Program.Main(new[] { "а" });
        }

        /// <summary>
        /// The more than 2 words in args.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void MoreThan2WordsInArgsTest()
        {
            Program.Main(new[] { "слово", "слово" });
        }

        /// <summary>
        /// The not russian word in args test.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void NotRussianWordInArgsTest()
        {
            Program.Main(new[] { "world" });
        }

        /// <summary>
        /// The entering incorrect words.
        /// </summary>
        /// <param name="value">
        /// The value.
        /// </param>
        [DataRow(new[] { "сло...во" })]
        [DataRow(new[] { "сло во" })]
        [DataRow(new[] { "сло/во" })]
        [DataTestMethod]
        public void EnteringIncorrectWords(string[] value)
        {
            try
            {
                Program.Main(value);
                Assert.Fail("An exception should have been thrown");
            }
            catch (ArgumentException ae)
            {
                Assert.AreEqual("only Russian letters and the '+' symbol are allowed.", ae.Message);
            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected exception of type {0} caught: {1}", e.GetType(), e.Message);
            }
        }

        /// <summary>
        /// The using more than one accents.
        /// </summary>
        [TestMethod]
        public void UsingMoreThanOneAccentsTest()
        {
            try
            {
                Program.Main(new[] { "моло+ко+" });
                Assert.Fail("An exception should have been thrown");
            }
            catch (ArgumentException ae)
            {
                Assert.AreEqual("Using more than one '+' symbol!", ae.Message);
            }
            catch (Exception e)
            {
                Assert.Fail("Unexpected exception of type {0} caught: {1}", e.GetType(), e.Message);
            }
        }
    }
}

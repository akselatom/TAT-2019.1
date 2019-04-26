
namespace DEV_4
{
    using System;

    /// <summary>
    /// The string extension.
    /// </summary>
    public static class StringExtension
    {
        /// <summary>
        /// Number of <see cref="Guid"/> objects. Required to generate unique ID
        /// </summary>
        private static readonly int Id = Guid.CallsNumber;

        /// <summary>
        /// The generate unique object description.
        /// </summary>
        /// <param name="input">
        /// input string
        /// </param>
        /// <returns>
        /// Return string with unique description.
        /// </returns>
        public static string GenerateUniqueObjectDescription(this string input)
        {
            return "unique description" + Id;
        }
    }
}